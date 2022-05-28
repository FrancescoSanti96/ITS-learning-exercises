'''
2. Inserita una stringa da tastiera indicare le vocali di cui è composta
'''

vocali = []

parola = input("Inserisci la stringa: ")

for x in parola.lower():
            if (x == 'a' or x == 'i' or x == 'e' or x == 'u' or x == 'o'):            
                vocali.append(x)

print("Le vocali nella stringa inserita: ",parola," sono: ",vocali)