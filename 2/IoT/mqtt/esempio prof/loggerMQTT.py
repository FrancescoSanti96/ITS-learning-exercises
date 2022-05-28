import threading, csv, queue, json
import paho.mqtt.client as paho

class logThread(threading.Thread):
    """
    legge dati da una queue "q". Il dato deve essere una lista: i dati della lista vengono messi in un file CSV
    """
    def __init__(self, campi):
        threading.Thread.__init__(self)
        self.filename="loggerThread.csv"

        with open(self.filename,'w', newline='') as fileHandle:
            csvwriter = csv.writer(fileHandle) 
            csvwriter.writerow(campi) 

    def run(self):
        while True: 
            print("In attesa...") 
            dato = q.get()            
            with open(self.filename,'a', newline='') as fileHandle:
                csvwriter = csv.writer(fileHandle) 
                print(dato)
                csvwriter.writerow(dato)

q = queue.Queue()
logger = logThread(["nome", "cognome", "voto"])
logger.start()

def on_subscribe(client, userdata, mid, granted_qos):
    print("Subscribed: "+str(mid)+" "+str(granted_qos))

def on_message(client, userdata, msg):
    print("console")
    #q.put(msg.topic+" "+str(msg.qos)+" "+str(msg.payload))    
    dato = str(msg.payload)
    print("ricevuta: ", dato)
    dato = dato.split('\'')[1]
    print("splittata: ", dato)
    dato = json.loads(dato) 
    q.put([dato["nome"], dato["cognome"], dato["voto"]])    
print(logThread.__doc__)

client = paho.Client()
client.on_subscribe = on_subscribe
client.on_message = on_message
client.connect("broker.mqttdashboard.com", 1883)
client.subscribe("its2022/casta", qos=1)

print("In esecuzione")
client.loop_forever()
