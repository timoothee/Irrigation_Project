import time
from adafruit_platformdetect import Detector
detector = Detector()
print("Chip id: ", detector.chip.id)
print("Board id: ", detector.board.id)

# Check for specific board models:
print("Pi 3B+? ", detector.board.D23)
print("BBB? ", detector.board.D23)
print("Orange Pi PC? ", detector.board.D23)
print("generic Linux PC? ", detector.board.D23)
import board
'''
import adafruit_dht
import psutil

# We first check if a libgpiod process is running. If yes, we kill it!

for proc in psutil.process_iter():
    if proc.name() == 'libgpiod_pulsein' or proc.name() == 'libgpiod_pulsei':
        proc.kill()
sensor = adafruit_dht.DHT11(board.D23)

while True:
    try:
        temp = sensor.temperature
        humidity = sensor.humidity
        print("Temperature: {}*C   Humidity: {}% ".format(temp, humidity))
    except RuntimeError as error:
        print(error.args[0])
        time.sleep(2.0)
        continue
    except Exception as error:
        sensor.exit()
        raise error
    time.sleep(2.0)
'''