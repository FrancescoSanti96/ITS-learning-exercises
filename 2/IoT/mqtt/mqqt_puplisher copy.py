import paho.mqtt.client as mqtt

mqttBroker= "broker.mqttdashboard.com"
client = mqtt.Client()
client.connect(mqttBroker)

# dentro la index prima del return
client.publish("nicola",temp)


# https://www.youtube.com/watch?v=kuyCd53AOtg
# 10.59