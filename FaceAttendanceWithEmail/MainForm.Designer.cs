namespace FaceRecognitionApp
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AddFace = new System.Windows.Forms.Button();
            this.TrainFaceNameTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.detectedName = new System.Windows.Forms.Label();
            this.faceCounter = new System.Windows.Forms.Label();
            this.imgBox = new Emgu.CV.UI.ImageBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CamSwitch = new System.Windows.Forms.Button();
            this.CameraList = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mailServerTxt = new System.Windows.Forms.TextBox();
            this.serverPortTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.subjectTxt = new System.Windows.Forms.TextBox();
            this.testMailBtn = new System.Windows.Forms.Button();
            this.saveMailBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sendToTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sendFromTxt = new System.Windows.Forms.TextBox();
            this.mailPassTxt = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AttendLogo = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.FaceList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TodayDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LeaveTime = new System.Windows.Forms.DateTimePicker();
            this.LastTime = new System.Windows.Forms.DateTimePicker();
            this.ClassTime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.CourseList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Attendance = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.TeacherMail = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendLogo)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FaceList)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Attendance)).BeginInit();
            this.SuspendLayout();
            // 
            // AddFace
            // 
            this.AddFace.Enabled = false;
            this.AddFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFace.Location = new System.Drawing.Point(244, 21);
            this.AddFace.Name = "AddFace";
            this.AddFace.Size = new System.Drawing.Size(78, 28);
            this.AddFace.TabIndex = 3;
            this.AddFace.Text = "Add face";
            this.AddFace.UseVisualStyleBackColor = true;
            this.AddFace.Click += new System.EventHandler(this.AddFaceBtn);
            // 
            // TrainFaceNameTxt
            // 
            this.TrainFaceNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainFaceNameTxt.Location = new System.Drawing.Point(53, 20);
            this.TrainFaceNameTxt.Name = "TrainFaceNameTxt";
            this.TrainFaceNameTxt.Size = new System.Drawing.Size(185, 29);
            this.TrainFaceNameTxt.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TrainFaceNameTxt);
            this.groupBox1.Controls.Add(this.AddFace);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 68);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training Face: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.detectedName);
            this.groupBox2.Controls.Add(this.faceCounter);
            this.groupBox2.Location = new System.Drawing.Point(355, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 68);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Counter: ";
            // 
            // detectedName
            // 
            this.detectedName.AutoSize = true;
            this.detectedName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectedName.ForeColor = System.Drawing.Color.Blue;
            this.detectedName.Location = new System.Drawing.Point(6, 27);
            this.detectedName.Name = "detectedName";
            this.detectedName.Size = new System.Drawing.Size(71, 19);
            this.detectedName.TabIndex = 16;
            this.detectedName.Text = "Unknown";
            // 
            // faceCounter
            // 
            this.faceCounter.AutoSize = true;
            this.faceCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faceCounter.ForeColor = System.Drawing.Color.Red;
            this.faceCounter.Location = new System.Drawing.Point(238, 27);
            this.faceCounter.Name = "faceCounter";
            this.faceCounter.Size = new System.Drawing.Size(15, 16);
            this.faceCounter.TabIndex = 15;
            this.faceCounter.Text = "0";
            this.faceCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgBox
            // 
            this.imgBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBox.Location = new System.Drawing.Point(3, 3);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(823, 471);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox.TabIndex = 4;
            this.imgBox.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 503);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(829, 477);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SETTINGS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.CamSwitch);
            this.groupBox3.Controls.Add(this.CameraList);
            this.groupBox3.Location = new System.Drawing.Point(116, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 65);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera";
            // 
            // CamSwitch
            // 
            this.CamSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CamSwitch.Location = new System.Drawing.Point(489, 16);
            this.CamSwitch.Name = "CamSwitch";
            this.CamSwitch.Size = new System.Drawing.Size(77, 34);
            this.CamSwitch.TabIndex = 8;
            this.CamSwitch.Text = "Camera On";
            this.CamSwitch.UseVisualStyleBackColor = true;
            this.CamSwitch.Click += new System.EventHandler(this.CamSwitch_Click);
            // 
            // CameraList
            // 
            this.CameraList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CameraList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CameraList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CameraList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CameraList.FormattingEnabled = true;
            this.CameraList.Location = new System.Drawing.Point(6, 18);
            this.CameraList.Name = "CameraList";
            this.CameraList.Size = new System.Drawing.Size(477, 32);
            this.CameraList.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.mailServerTxt);
            this.groupBox6.Controls.Add(this.serverPortTxt);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.subjectTxt);
            this.groupBox6.Controls.Add(this.testMailBtn);
            this.groupBox6.Controls.Add(this.saveMailBtn);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.sendToTxt);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.sendFromTxt);
            this.groupBox6.Controls.Add(this.mailPassTxt);
            this.groupBox6.Location = new System.Drawing.Point(116, 84);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(584, 212);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Mail Setup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "SMTP Server:";
            // 
            // mailServerTxt
            // 
            this.mailServerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailServerTxt.Location = new System.Drawing.Point(111, 80);
            this.mailServerTxt.MaxLength = 30;
            this.mailServerTxt.Name = "mailServerTxt";
            this.mailServerTxt.Size = new System.Drawing.Size(355, 24);
            this.mailServerTxt.TabIndex = 11;
            this.mailServerTxt.Text = "mail.esinebd.com";
            // 
            // serverPortTxt
            // 
            this.serverPortTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverPortTxt.Location = new System.Drawing.Point(111, 111);
            this.serverPortTxt.MaxLength = 30;
            this.serverPortTxt.Name = "serverPortTxt";
            this.serverPortTxt.Size = new System.Drawing.Size(355, 24);
            this.serverPortTxt.TabIndex = 12;
            this.serverPortTxt.Text = "465";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Subject:";
            // 
            // subjectTxt
            // 
            this.subjectTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectTxt.Location = new System.Drawing.Point(111, 171);
            this.subjectTxt.MaxLength = 50;
            this.subjectTxt.Name = "subjectTxt";
            this.subjectTxt.Size = new System.Drawing.Size(355, 24);
            this.subjectTxt.TabIndex = 8;
            // 
            // testMailBtn
            // 
            this.testMailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testMailBtn.Location = new System.Drawing.Point(474, 172);
            this.testMailBtn.Name = "testMailBtn";
            this.testMailBtn.Size = new System.Drawing.Size(92, 24);
            this.testMailBtn.TabIndex = 7;
            this.testMailBtn.Text = "Test Mail";
            this.testMailBtn.UseVisualStyleBackColor = true;
            this.testMailBtn.Click += new System.EventHandler(this.TestMailBtn_Click);
            // 
            // saveMailBtn
            // 
            this.saveMailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveMailBtn.Location = new System.Drawing.Point(474, 111);
            this.saveMailBtn.Name = "saveMailBtn";
            this.saveMailBtn.Size = new System.Drawing.Size(92, 54);
            this.saveMailBtn.TabIndex = 6;
            this.saveMailBtn.Text = "Save";
            this.saveMailBtn.UseVisualStyleBackColor = true;
            this.saveMailBtn.Click += new System.EventHandler(this.SaveMailBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gmail[Send to]:";
            // 
            // sendToTxt
            // 
            this.sendToTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendToTxt.Location = new System.Drawing.Point(111, 141);
            this.sendToTxt.MaxLength = 30;
            this.sendToTxt.Name = "sendToTxt";
            this.sendToTxt.Size = new System.Drawing.Size(355, 24);
            this.sendToTxt.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Gmail[Send from]:";
            // 
            // sendFromTxt
            // 
            this.sendFromTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendFromTxt.Location = new System.Drawing.Point(111, 19);
            this.sendFromTxt.MaxLength = 30;
            this.sendFromTxt.Name = "sendFromTxt";
            this.sendFromTxt.Size = new System.Drawing.Size(355, 24);
            this.sendFromTxt.TabIndex = 0;
            this.sendFromTxt.Text = "project@esinebd.com";
            // 
            // mailPassTxt
            // 
            this.mailPassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailPassTxt.Location = new System.Drawing.Point(111, 50);
            this.mailPassTxt.MaxLength = 30;
            this.mailPassTxt.Name = "mailPassTxt";
            this.mailPassTxt.Size = new System.Drawing.Size(355, 24);
            this.mailPassTxt.TabIndex = 1;
            this.mailPassTxt.Text = "u4kC2CnYikpEcDs";
            this.mailPassTxt.UseSystemPasswordChar = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AttendLogo);
            this.tabPage1.Controls.Add(this.imgBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(829, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LIVE CAM";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AttendLogo
            // 
            this.AttendLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AttendLogo.BackColor = System.Drawing.Color.Transparent;
            this.AttendLogo.Image = ((System.Drawing.Image)(resources.GetObject("AttendLogo.Image")));
            this.AttendLogo.Location = new System.Drawing.Point(736, 15);
            this.AttendLogo.Name = "AttendLogo";
            this.AttendLogo.Size = new System.Drawing.Size(76, 79);
            this.AttendLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AttendLogo.TabIndex = 5;
            this.AttendLogo.TabStop = false;
            this.AttendLogo.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.FaceList);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(829, 477);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "FACE LIST";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // FaceList
            // 
            this.FaceList.BackgroundColor = System.Drawing.Color.White;
            this.FaceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FaceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.FaceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FaceList.Location = new System.Drawing.Point(0, 0);
            this.FaceList.Name = "FaceList";
            this.FaceList.ReadOnly = true;
            this.FaceList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FaceList.Size = new System.Drawing.Size(829, 477);
            this.FaceList.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.FillWeight = 70F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Face ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 200F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Student Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.TeacherMail);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.TodayDate);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.LeaveTime);
            this.tabPage2.Controls.Add(this.LastTime);
            this.tabPage2.Controls.Add(this.ClassTime);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.CourseList);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Attendance);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(829, 477);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "ATTENDANCE";
            // 
            // TodayDate
            // 
            this.TodayDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TodayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TodayDate.Location = new System.Drawing.Point(580, 47);
            this.TodayDate.Name = "TodayDate";
            this.TodayDate.Size = new System.Drawing.Size(242, 20);
            this.TodayDate.TabIndex = 12;
            this.TodayDate.Text = "Today: ";
            this.TodayDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(538, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Leave Time Start:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(253, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Last Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Class Time:";
            // 
            // LeaveTime
            // 
            this.LeaveTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LeaveTime.Enabled = false;
            this.LeaveTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.LeaveTime.Location = new System.Drawing.Point(677, 78);
            this.LeaveTime.Name = "LeaveTime";
            this.LeaveTime.Size = new System.Drawing.Size(145, 26);
            this.LeaveTime.TabIndex = 8;
            // 
            // LastTime
            // 
            this.LastTime.Enabled = false;
            this.LastTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.LastTime.Location = new System.Drawing.Point(341, 78);
            this.LastTime.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.LastTime.Name = "LastTime";
            this.LastTime.Size = new System.Drawing.Size(145, 26);
            this.LastTime.TabIndex = 7;
            // 
            // ClassTime
            // 
            this.ClassTime.Enabled = false;
            this.ClassTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ClassTime.Location = new System.Drawing.Point(102, 78);
            this.ClassTime.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.ClassTime.Name = "ClassTime";
            this.ClassTime.Size = new System.Drawing.Size(145, 26);
            this.ClassTime.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(270, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Select Course:";
            // 
            // CourseList
            // 
            this.CourseList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CourseList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseList.FormattingEnabled = true;
            this.CourseList.Location = new System.Drawing.Point(389, 39);
            this.CourseList.Name = "CourseList";
            this.CourseList.Size = new System.Drawing.Size(121, 28);
            this.CourseList.TabIndex = 4;
            this.CourseList.SelectedIndexChanged += new System.EventHandler(this.CourseList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(540, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Daily Student Attendance System";
            // 
            // Attendance
            // 
            this.Attendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Attendance.BackgroundColor = System.Drawing.Color.White;
            this.Attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Attendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column5,
            this.dataGridViewTextBoxColumn2,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.Attendance.Location = new System.Drawing.Point(5, 110);
            this.Attendance.Name = "Attendance";
            this.Attendance.ReadOnly = true;
            this.Attendance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Attendance.Size = new System.Drawing.Size(817, 361);
            this.Attendance.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 70F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Face ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Student ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Student Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Dept. Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 120F;
            this.Column2.HeaderText = "Record";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 120F;
            this.Column3.HeaderText = "Arrival Time";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 120F;
            this.Column4.HeaderText = "Leave Time";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Email To:";
            // 
            // TeacherMail
            // 
            this.TeacherMail.Location = new System.Drawing.Point(86, 44);
            this.TeacherMail.Name = "TeacherMail";
            this.TeacherMail.ReadOnly = true;
            this.TeacherMail.Size = new System.Drawing.Size(161, 20);
            this.TeacherMail.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 601);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Face Attendance App";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AttendLogo)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FaceList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Attendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddFace;
        private Emgu.CV.UI.ImageBox imgBox;
        private System.Windows.Forms.TextBox TrainFaceNameTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label detectedName;
        private System.Windows.Forms.Label faceCounter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView FaceList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CamSwitch;
        private System.Windows.Forms.ComboBox CameraList;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox subjectTxt;
        private System.Windows.Forms.Button testMailBtn;
        private System.Windows.Forms.Button saveMailBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sendToTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sendFromTxt;
        private System.Windows.Forms.TextBox mailPassTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mailServerTxt;
        private System.Windows.Forms.TextBox serverPortTxt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Attendance;
        private System.Windows.Forms.Label TodayDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker LeaveTime;
        private System.Windows.Forms.DateTimePicker LastTime;
        private System.Windows.Forms.DateTimePicker ClassTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CourseList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PictureBox AttendLogo;
        private System.Windows.Forms.TextBox TeacherMail;
        private System.Windows.Forms.Label label13;
    }
}

