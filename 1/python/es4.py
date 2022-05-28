'''
Assegnato un file di testo e una parola assegnata creare un secondo file uguale al primo 
ma in cui  ogni riga sia terminata dalla parola indicata  
'''

parola = ""
parola = input("Inserisci la parola con cui terminare ogni riga nel nuovo file: ")
n = ""

with open("dataEs4/file.txt", "r") as file:
    fwrite = open("dataEs4/nuovoFile.txt", "w")
    text = list(file)
    for x in text:
        n = str(x[0:-1]) + parola +"\n"
        fwrite.write(n)
        n = ""

fwrite.close()
file.close()
