import paho.mqtt.client as mqtt
from random import randrange, uniform
import time

mqttBroker= "broker.mqttdashboard.com"
client = mqtt.Client()
client.connect(mqttBroker)

while True:
    randNumber = uniform(20.0,21.0)
    client.publish("fra",randNumber)
    print("Just published" + str(randNumber) + "to topic fra")
    time.sleep(1)

# https://www.youtube.com/watch?v=kuyCd53AOtg
# 10.59