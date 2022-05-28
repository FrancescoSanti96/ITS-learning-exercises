# Esercizio One Way Hash Function

from decimal import InvalidOperation
import hashlib

# Funzione di invio del messaggio
def sender(msg, key):
    strHash = str(key + msg + key)
    resultHash = (hashlib.md5(strHash.encode())).hexdigest()
    result = str(msg + resultHash)
    return result

# Funzione di ricezione del messaggio
def receiver(msg, key, msgHash):
    strHash = str(key + msg + key)
    resultHash = (hashlib.md5(strHash.encode())).hexdigest()
    hash = msgHash.removeprefix(msg)
    if resultHash == hash:
        return True
    else:
        return False


# Esecuzione del programma
exit = False;
while (exit != True):
    print("Selezionare la modalità:0 exit (uscire dal programma) 1 sender ; 2 receiver")
    n=input("")

    if n == '0':
        exit = True

    elif n == '1':
        print("\nInserire il messaggio da inviare:")
        msg=input("")
        print("\nInserire la chiave da utilizzare per creare l'impronta hash:")
        key=input("")
        send = sender(msg, key)
        print("\nIl messaggio con l'impronta hash è:", send ,"\n")

    elif n == '2':
        print("\nInserire il messaggio con hash ricevuto:")
        msgHash=input("")
        print("\nInserire solo il messaggio ricevuto:")
        msg=input("")
        print("\nInserire la chiave da utilizzare per eseguire la verifica dell'impronta hash:")
        key=input("")
        check = receiver(msg, key, msgHash)
        print("\nIl messaggio corrorisponde all'orginiale:", check,"\n")