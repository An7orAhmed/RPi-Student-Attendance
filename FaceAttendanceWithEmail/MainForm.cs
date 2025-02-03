using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using DirectShowLib;
using System.Net.Mail;
using System.Threading.Tasks;

namespace FaceRecognitionApp {
    public partial class MainForm : Form {
        Image<Bgr, byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_PLAIN, 0.6d, 0.6d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, prevIndex = -1;
        string name, names = null;
        string[][] students;
        DateTime[] classTimeList, lastTimeList, leaveTimeList;
        string[] teacherMailList;

        public MainForm() {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e) {
            CheckForIllegalCrossThreadCalls = false;

            DsDevice[] _SystemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            foreach (DsDevice _Camera in _SystemCamereas) {
                CameraList.Items.Add(_Camera.Name);
            }
            if (CameraList.Items.Count > 0) CameraList.SelectedIndex = 0;

            sendFromTxt.Text = Properties.Settings.Default.sendFrom;
            mailPassTxt.Text = Properties.Settings.Default.pass;
            sendToTxt.Text = Properties.Settings.Default.sendTo;
            mailServerTxt.Text = Properties.Settings.Default.server;
            serverPortTxt.Text = Properties.Settings.Default.port;
            subjectTxt.Text = Properties.Settings.Default.subject;

            TodayDate.Text = "TODAY: " + DateTime.Now.Date.ToString("dd-MMM-yy");

            string file = Application.StartupPath + "/Courses/courses.csv";
            if (File.Exists(file)) {
                int i = 0;
                string[] courses = File.ReadAllLines(file);
                students = new string[courses.Length][];
                classTimeList = new DateTime[courses.Length];
                lastTimeList = new DateTime[courses.Length];
                leaveTimeList = new DateTime[courses.Length];
                teacherMailList = new string[courses.Length];

                foreach (var course in courses) {
                    string[] line = course.Split(',');
                    CourseList.Items.Add(line[0]);
                    string today = DateTime.Now.Date.ToString("dd/MM/yyyy");
                    classTimeList[i] = DateTime.Parse(today + " " + line[1]);
                    lastTimeList[i] = DateTime.Parse(today + " " + line[2]);
                    leaveTimeList[i] = DateTime.Parse(today + " " + line[3]);
                    teacherMailList[i] = line[4];

                    file = Application.StartupPath + "/Courses/Students/" + line[0] + ".csv";
                    if (File.Exists(file)) students[i] = File.ReadAllLines(file);
                    i++;
                }
                if (CourseList.Items.Count > 0) {
                    CourseList.SelectedIndex = 0;
                    prevIndex = 0;
                }
            }
            else MessageBox.Show("Courses.csv file not found!");

            InitFaceRecognizer();
            LoadFaceList();
        }

        private void InitFaceRecognizer() {
            try {
                face = new HaarCascade("haarcascade_frontalface_default.xml");
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++) {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }

            }
            catch (Exception) {
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AddFaceBtn(object sender, EventArgs e) {
            try {
                ContTrain++;
                gray = grabber.QueryGrayFrame().Resize(320, 240, INTER.CV_INTER_CUBIC);

                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 10, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

                foreach (MCvAvgComp f in facesDetected[0]) {
                    TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }

                TrainedFace = result.Resize(100, 100, INTER.CV_INTER_CUBIC);
                trainingImages.Add(TrainedFace);
                labels.Add(TrainFaceNameTxt.Text);
                File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++) {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
                }
                LoadFaceList();

                MessageBox.Show(TrainFaceNameTxt.Text + "´s face detected and added :)", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch {
                MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void FrameGrabber(object sender, EventArgs e) {
            faceCounter.Text = "0";
            NamePersons.Clear();
            currentFrame = grabber.QueryFrame().Resize(320, 240, INTER.CV_INTER_CUBIC).Flip(FLIP.HORIZONTAL);
            gray = currentFrame.Convert<Gray, Byte>();
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                  face,
                  1.2,
                  4,
                  HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                  new Size(20, 20));

            foreach (MCvAvgComp f in facesDetected[0]) {
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                currentFrame.Draw(f.rect, new Bgr(Color.Yellow), 1);


                if (trainingImages.ToArray().Length != 0) {
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                    var recognizer = new CustomEigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 3000, ref termCrit);
                    name = recognizer.Recognize(result);

                    currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.White));
                }
                NamePersons.Add(name);
            }

            for (int nnn = 0; nnn < facesDetected[0].Length; nnn++) names += NamePersons[nnn] + ",";
            imgBox.Image = currentFrame;
            detectedName.Text = names;
            faceCounter.Text = facesDetected[0].Length.ToString();

            if (detectedName.Text.Length > 2) {
                AttendLogo.Visible = true;
                AttendanceCount(names);
            }
            else AttendLogo.Visible = false;

            names = "";
            NamePersons.Clear();
        }

        private void AttendanceCount(string value) {
            try {
                string[] names = value.Split(',');
                if (names[0] == "") return;
                for (int r = 0; r < Attendance.Rows.Count - 1; r++) {
                    if (names[0] == Attendance.Rows[r].Cells[2].Value.ToString()) {
                        var cTime = new DateTime();
                        cTime = DateTime.Now;
                        if (cTime <= LastTime.Value) {
                            if (Attendance.Rows[r].Cells[5].Value == null) {
                                Attendance.Rows[r].Cells[5].Value = cTime.ToString("hh:mm tt");
                                if (cTime >= ClassTime.Value) {
                                    Attendance.Rows[r].Cells[4].Value = "LATE";
                                    Attendance.Rows[r].Cells[4].Style.BackColor = Color.Yellow;
                                    Attendance.Rows[r].Cells[4].Style.ForeColor = Color.Black;
                                }
                                else {
                                    Attendance.Rows[r].Cells[4].Value = "PRESENT";
                                    Attendance.Rows[r].Cells[4].Style.BackColor = Color.Lime;
                                    Attendance.Rows[r].Cells[4].Style.ForeColor = Color.Black;
                                }
                            }
                        }
                        else if (cTime >= LeaveTime.Value) {
                            if (Attendance.Rows[r].Cells[6].Value.ToString() != "") {
                                Attendance.Rows[r].Cells[6].Value = cTime.ToString("hh:mm tt");
                            }
                        }
                        break;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void CamSwitch_Click(object sender, EventArgs e) {
            try {
                grabber = new Capture(CameraList.SelectedIndex);
                grabber.QueryFrame();
                Application.Idle += new EventHandler(FrameGrabber);
                CamSwitch.Enabled = false;
                AddFace.Enabled = true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void TestMailBtn_Click(object sender, EventArgs e) {
            Attachment img = new Attachment(Application.StartupPath + "/default.png");
            Task.Run(new Action(() => SendMail(sendToTxt.Text, img)));
        }

        private void CourseList_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                SaveAttendance();
                prevIndex = CourseList.SelectedIndex;
                ClassTime.Value = classTimeList[CourseList.SelectedIndex];
                LastTime.Value = lastTimeList[CourseList.SelectedIndex];
                LeaveTime.Value = leaveTimeList[CourseList.SelectedIndex];
                TeacherMail.Text = teacherMailList[CourseList.SelectedIndex];

                Attendance.Rows.Clear();
                for (int i = 0; i < students[CourseList.SelectedIndex].Length; i++) {
                    string student = students[CourseList.SelectedIndex][i];
                    string[] line = student.Split(',');
                    string[] row = new string[4];
                    line.CopyTo(row, 0);
                    row[3] = CourseList.Items[CourseList.SelectedIndex].ToString();
                    Attendance.Rows.Add(row);
                    Attendance.Rows[i].Cells[4].Value = "ABSENT";
                    Attendance.Rows[i].Cells[4].Style.BackColor = Color.Red;
                    Attendance.Rows[i].Cells[4].Style.ForeColor = Color.White;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveAttendance() {
            if (prevIndex == -1) return;
            string today = DateTime.Now.ToString("dd_MMM_yy");
            string dept = CourseList.Items[prevIndex].ToString();
            string file = Application.StartupPath + "/Attendance/" + dept + "_" + today + ".csv";

            using (var csv = new StreamWriter(file)) {
                for (int c = 0; c < Attendance.Columns.Count; c++) {
                    csv.Write(Attendance.Columns[c].HeaderText);
                    if (c != Attendance.Columns.Count - 1) csv.Write(",");
                }
                csv.WriteLine();
                for (int r = 0; r < Attendance.Rows.Count; r++) {
                    for (int c = 0; c < Attendance.Columns.Count; c++) {
                        if (Attendance.Rows[r].Cells[c].Value == null) continue;
                        csv.Write(Attendance.Rows[r].Cells[c].Value.ToString());
                        if (c != Attendance.Columns.Count - 1) csv.Write(",");
                    }
                    csv.WriteLine();
                }
                csv.Close();
            }

            Attachment attach = new Attachment(file);
            Task.Run(new Action(() => SendMail(TeacherMail.Text, attach)));
        }

        private void SendMail(string sendTo, Attachment img) {
            if (mailServerTxt.Text == "") {
                MessageBox.Show("SMTP server is empty!");
                return;
            }
            if (serverPortTxt.Text == "") {
                MessageBox.Show("SMTP server port is empty!");
                return;
            }
            if (sendFromTxt.Text == "") {
                MessageBox.Show("Mail sender is empty!");
                return;
            }
            if (mailPassTxt.Text == "") {
                MessageBox.Show("Mail password is empty!");
                return;
            }

            Console.WriteLine("Sending mail...");
            MailMessage mail = new MailMessage();
            SmtpClient mailSender = new SmtpClient() {
                Host = mailServerTxt.Text,
                Port = int.Parse(serverPortTxt.Text),
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential(sendFromTxt.Text, mailPassTxt.Text),
                EnableSsl = true,
                Timeout = 20000
            };

            mail.From = new MailAddress(sendFromTxt.Text);
            mail.To.Add(sendTo);
            mail.Subject = subjectTxt.Text;
            mail.Body = "This is an auto generated report from attendance software.";
            mail.Attachments.Add(img);

            try {
                mailSender.Send(mail);
                MessageBox.Show("Email sent successfully.");
                Console.WriteLine("sent.");
                mailSender.Dispose();
                mail.Dispose();
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        private void SaveMailBtn_Click(object sender, EventArgs e) {
            Properties.Settings.Default.sendFrom = sendFromTxt.Text;
            Properties.Settings.Default.pass = mailPassTxt.Text;
            Properties.Settings.Default.sendTo = sendToTxt.Text;
            Properties.Settings.Default.server = mailServerTxt.Text;
            Properties.Settings.Default.port = serverPortTxt.Text;
            Properties.Settings.Default.subject = subjectTxt.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Setting saved.");
        }

        private void LoadFaceList() {
            var path = Application.StartupPath + "/TrainedFaces/TrainedLabels.txt";
            if (File.Exists(path)) {
                string[] lines = File.ReadAllText(path).Split('%');
                FaceList.Rows.Clear();
                for (int i = 1; i < lines.Length - 1; i++) {
                    string line = lines[i];
                    FaceList.Rows.Add(i, line);
                }
            }
        }
    }
}