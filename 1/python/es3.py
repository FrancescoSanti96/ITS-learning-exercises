'''
Assegnata una sequenza di stringhe da tastiera (terminata con la parola “end”)
visualizzare per ogni  stringa l’insieme delle vocali che la compongono  
'''

sequenzaStr = []
vocali = []

stringa = ""
while stringa!= "end":
    stringa = input("Inserisci la stringa ('end' per finire): ")
    if stringa != "end":
        sequenzaStr.append(stringa)


for y in sequenzaStr:
    for x in y.lower():
                if (x == 'a' or x == 'i' or x == 'e' or x == 'u' or x == 'o'):            
                    vocali.append(x)
    print("Le vocali nella stringa inserita: ",y, "sono: ",vocali)
    vocali = []