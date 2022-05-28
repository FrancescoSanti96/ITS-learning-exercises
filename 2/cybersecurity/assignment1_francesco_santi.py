# Esercizio 1: Creare il cifrario di cesare
alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz123456789 !?."

def caesar(msg, key, mode):
    if(mode == "cript"):
        messaggio = ""
        for lettera in msg:
            # posizione di lettere in alfabeto
            posizione = alfabeto.find(lettera)

            # Se non supero la lunghezza dell'alfabeto
            if((posizione + key)<len(alfabeto)):
                # messaggio ci appendo la lettera in posizione + key
                messaggio += alfabeto[posizione + key]
            else:
                # Nel caso in cui si supera la lunghezza dell'alfabeto o pensato di usare il resto della divisone per calcolare di quanti posti spostarsi, Esempio nel nostro caso alfabeto è lungo 65 duqnue se li dico di spostarsi di 65 posizioni equivale a dirli di ritornare la solito posto.
                 messaggio += alfabeto[(posizione + key) % len(alfabeto)]
        return messaggio

    if(mode == "decript"):
        messaggio = ""
        for lettera in msg:
            # posizione di lettere in alfabeto
            posizione = alfabeto.find(lettera)
            # Se non supero la lunghezza dell'alfabeto
            if((posizione - key)<len(alfabeto)):
                # messaggio ci appendo la lettera in posizione + key
                messaggio += alfabeto[posizione - key]
            # Se supero la lunghezza dell'alfabeto
            else:
                messaggio += alfabeto[(posizione - key) % len(alfabeto)]
        return messaggio


# Esercizio 2: brute force
def bruteForce(msgCriptato):
    # partendo da 0 conto come x valido fino a 64 compreso dopo di che sarebbe ridondante
    for x in range(65):
        print(caesar(msgCriptato,x,"decript"))
    return "prova"


# Esercizio 3: Creazione funzione isEnglish
inglese = "123456789!?."
def isEnglish(message):
    message = message.split(' ')
    nParole, nLettere = 0, 0
    risultato = False
    percentualeParole = 20 * len(message) / 100
 
    # controlle se le parole sono all'interno del dictionary.txt e se la percentuale rispecchia la richesta
    with open('dictionary.txt') as f:
        for x in message:
            if x.upper() in f.read():
                nParole += 1
    if nParole >= percentualeParole:
        # Se il numero di parole trovate è superiore alla percentuale richiesta allora controllo 
        # se le lettere delle varie parole del messaggio rispecchiano le richieste
        count = 0
        for x in message:
            count += len(x)
            for y in x:
                if y not in inglese:
                    nLettere += 1
        percentualeLettere = 85 * count / 100
        if nLettere >= percentualeLettere:
            # Se si allora la parola/frase con alte probabilità è inglese
            risultato= True
    return risultato


# Esercizio 3.1
# Creazione funzione brute force con utilizzo della funzione isEnglish
def bruteForceEnglish(msgCriptato):
    for x in range(65):
        if isEnglish(caesar(msgCriptato,x,"decript")) == True:
            result = caesar(msgCriptato,x,"decript")
            return result


# Esecuzione del programma
exit = False;
while (exit != True):
    print("Selezionare la modalità:0 exit (uscire dal programma) 1 cript ; 2 decript ; 3 Bruteforce ; 4 IsEnglish")
    n=input("")

    if n == '0':
        exit = True

    elif n == '1':
        print("\nInserire il messaggio da criptare con il cifrario di Cesare:")
        msg=input("")
        print("\nInserire la chiave da utilizzare:")
        key=int(input(""))
        messaggioCriptato = caesar(msg,key,"cript")
        print("\nIl messaggio criptatio è:", messaggioCriptato)

    elif n == '2':
        print("\nInserire il messaggio da decriptare:")
        msg=input("")
        print("\nInserire la chiave da utilizzare:")
        key=int(input(""))
        messaggioCriptato = caesar(msg,key,"decript")
        print("\nIl messaggio decriptato è:", messaggioCriptato)
    
    elif n == '3':
        print("\nInserire il messaggio da decriptare con l'attacco Brute force:")
        msg=input("")
        print("Elenco:\n")
        bruteForce(msg)

    elif n == '4':
        print("\nInserire il messaggio da decriptare con l'attacco Brute force is English:")
        msg=input("")
        print("Risultato:\n")
        print(bruteForceEnglish(msg))