import serial
import time

gsm = serial.Serial('/dev/serial0', baudrate=9600, timeout=1)

def init():
    gsm.write(b"AT\r\n")
    time.sleep(0.3)
    gsm.write(b"AT+CMGF=1\r\n")
    time.sleep(0.3)
    gsm.write(b"AT+CNMI=1,2,0,0,0\r\n")
    time.sleep(10)
    print('GSM STARTED.')
    
def sendSMS(number, msg):
    print('Sending Message…')
    gsm.write(b'AT+CMGF=1\r\n')
    time.sleep(1)
    gsm.write(b'AT+CMGS="' + number.encode() + b'"\r\n')
    time.sleep(1)
    gsm.reset_output_buffer()
    time.sleep(1)
    gsm.write(str.encode(msg+chr(26)))
    time.sleep(3)
    print('message sent.')
    
def call(number):
    gsm.write(b"ATD%s;\r\n"%(number.encode()))
    print("Calling to: %s."%(number))
    
if __name__ == "__main__":
    init()
    call("01764180287")
    #sendSMS("01764180287", "Testing SMS from Python.")
    