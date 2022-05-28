'''
Leggere da tastiera un numero intero N e una sequenza terminata da 0. Visualizzare in uscita quanti  
sono i numeri della sequenza che sono minori, quanti maggiori e quanti uguali a 
'''
#Istanzio le variabili, ed il messaggio.
sequenza = []
messaggio = "Valore non intero, non inserito in elenco, prego inserire intero valido"

maggiore = 0
minore = 0
uguale = 0

#Serve per il while
n = 1
#Il numero da inserire da tastiera su cui fare il confronto della sequenza
while n!=0:
    
    try:
        valore = int(input("Inserisci il valore da usare per il confronto: "))
        n = 0
    except:
        print(messaggio)



#Inserisco da tastiera i numeri da aggiungere alla sequenza e con il numero 0 finisco l'inserimento.
n = 1
while n!=0:
    
    try:
        n = int(input("Inserisci numero (0 per finire): "))
        if n != 0:
            sequenza.append(n)
    except:
        print(messaggio)
        
#Eseguo il confronto
for x in sequenza:
    if (x > valore):
        maggiore += 1
    elif (x < valore):
        minore += 1
    elif (x == valore): 
        uguale += 1


print("I numeri maggiori di: " , valore, " sono: ", maggiore)
print("I numeri minori di: " , valore, " sono: ", minore)
print("I numeri uguali di: " , valore, " sono: ", uguale)
