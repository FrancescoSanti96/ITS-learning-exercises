import paho.mqtt.client as paho
import time

def on_connect(client, userdata, flags, rc):
    print('CONNACK received with code %d.' % (rc))
    
def on_publish(client, userdata, mid):
    print("mid: "+str(mid))
 
client = paho.Client()
client.on_connect = on_connect
client.on_publish = on_publish
client.connect("broker.mqttdashboard.com", 1883)
client.loop_start()

while True:
    messaggio = "valore inviato da console"
    (rc, mid) = client.publish("its2022/casta", messaggio, qos=1)
    time.sleep(5)