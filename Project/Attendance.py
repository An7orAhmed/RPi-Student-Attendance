import requests
from datetime import datetime, timedelta
import time
import Fingerprint
from gpiozero import LED
import SIM800

HOST = "http://localhost/"

buzzer = LED(25)
blueLed = LED(8)
greenLed = LED(7)
redLed = LED(1)
buzzer.off()
blueLed.off()
greenLed.off()
redLed.off()

startTime, endTime, smsFlag = 0, 0, 0
students = []

def getStudents():
    global students
    print(">> Reading Students...")
    resp = requests.get(HOST + "action.php", params={'list' : ''})
    students = resp.json()

def getSettings():
    global startTime, endTime, smsFlag
    print(">> Reading Settings...")
    resp = requests.get(HOST + "action.php", params={'settings' : ''})
    obj = resp.json()
    startTime = obj[2]['value']
    endTime = obj[3]['value']
    smsFlag = obj[4]['value']
    startTime = datetime.strptime(startTime, '%H:%M:%S')
    endTime = datetime.strptime(endTime, '%H:%M:%S')
    startTime.strftime('%I:%M:%S')
    endTime.strftime('%I:%M:%S')
    st = str(startTime).split(' ')[1]
    et = str(endTime).split(' ')[1]
    startTime = datetime.strptime(st, '%I:%M:%S').time()
    endTime = datetime.strptime(et, '%I:%M:%S').time()
    
    print('Start Time: ', startTime)
    print('End Time: ', endTime)
    print('SMS System: ', smsFlag)
    
def beep(dly):
    buzzer.on()
    time.sleep(dly)
    buzzer.off()

def setArrival(cTime, today, fId):
    global students, smsFlag
    param = {'get': '', 'id': fId, 'date': today}
    resp = requests.get(HOST + "action.php", params=param)
    obj = resp.json()
    if obj[0]['arrival_time'] == '':  
        remarks = "In Time"
        cTime = str(cTime).split('.')[0]
        param = {'arrive': '', 'id': fId, 'date': today, 'time': cTime, 'remarks': remarks}
        resp = requests.get(HOST + "action.php", params=param)
        print(">> Record updated.")
        if smsFlag == '1':
            name, number = "", ""
            for student in students:
                if student['fingerId'] == str(fId):
                    name = student['name']
                    number = student['phone']
                    break
            if not name == '':
                msg = name + " is present on " + str(today) + " at " + cTime
                blueLed.on()
                SIM800.sendSMS(number, msg)
                blueLed.off()
    else:
        print(">> Already updated!")
        beep(0.5)

def main():
    getSettings()
    getStudents()
    SIM800.init()
    prevTime = time.time()
    systemFlag = False
    today = datetime.now().strftime("%d-%b-%y")
    cTime = 0
    redLed.on()

    while True:
        if Fingerprint.get_fingerprint():
            fId = Fingerprint.finger.finger_id
            confidence = Fingerprint.finger.confidence
            print(">> Detected #", fId)
            print(">> Confidence: ", confidence)
            
            if fId >= 1 and fId <= 9:
                systemFlag = not systemFlag
                if systemFlag == True:
                    print(">> Attendance is ON")
                    greenLed.on()
                    redLed.off()
                    beep(0.2)
                else:
                    print(">> Attendance is OFF")
                    greenLed.off()
                    redLed.on()
                    beep(0.2)
            else:
                if systemFlag == True:
                    cTime = datetime.now().strftime('%I:%M:%S')
                    cTime = datetime.strptime(cTime, '%I:%M:%S').time()
                    print("Time: ", cTime)
                    if cTime >= startTime and cTime <= endTime:
                        setArrival(cTime, today, fId)
                    else:
                        print(">> Out of Class time!")
                        beep(0.5)
                else:
                    print(">> Attendance isn't allowed!")
                    beep(0.5)
        else:
            print(">> Finger not found!")
            beep(0.5)
        
        if time.time() - prevTime >= 30:
            getSettings()
            getStudents()
            prevTime = time.time()
    
if __name__ == "__main__":
    main()