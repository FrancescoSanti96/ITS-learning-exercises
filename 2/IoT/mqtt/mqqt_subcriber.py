from pydoc import cli
import paho.mqtt.client as mqtt
import time

def on_message(client,userdata, message):
    print("Messaggio ricevuto: ", str(message.payload.decode("utf-8")))

mqttBroker= "broker.mqttdashboard.com"
client = mqtt.Client()
client.connect(mqttBroker)

client.loop_start()
client.subscribe("fra")
client.on_message = on_message
time.sleep(30)
client.loop_end()