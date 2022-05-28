import threading, time, queue
 
class ProvaThread(threading.Thread):
    def __init__(self, i,q): #costruttore della classe
        threading.Thread.__init__(self) #chiamata al costruttore padre
        self.i = i      #creazione delle proprietà della classe
        self.q = q
 
    def func (self): #funzione della classe
        while(True):
            task = self.q.get() #prebde il primo "task" disponibile nella queue
            time.sleep(2) #il thread si ferma per 2 secondi
            q.task_done() #chiude il task0
            print(f'Thread #{self.i} is doing task #{task} in the queue') #stampa quale thread stia lavorando e a che cosa stia lavorando
 
    def run(self): #funzione che parte alla chiamata del metodo "thread.start()"
        time.sleep(0.5)
        self.func()
 
workers = [] #creazione della lista in cui poi andranno i vari thread
 
q = queue.Queue()
 
for i in range(0,4):   #creazione dei thread
    workers.append(ProvaThread(i,q)) #aggiunge il thread alla lista
    workers[i].daemon = True #quando il programma finisce se ci sono dei thread attivi vengono chiusi tutti
    workers[i].start() #fa partire il thread

for j in range (0,10): #ciclo
    q.put(j) #aggiungere alla queue dei valori casuali
 
q.join()
