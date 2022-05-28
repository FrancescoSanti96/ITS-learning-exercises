'''
Assegnato un file CSV con campi (nome, cognome, email), 
indicare se risulta presente il cognome  inserito da tastiera e visualizzare l’email corrispondente  
'''
import csv
utentiCsv = open("dataEs5/utenti.csv","r")

utenti = csv.reader(utentiCsv, delimiter = ",")
next(utenti)
cognome = input("Cognome --> ")
for x in utenti:
    if x[1] == cognome:
        print("Il cognome risulta presente, l'email corrispondente è la seguente: ", x[2])
       
utentiCsv.close()
