'''
Simulare l’esperimento di lancio di 3 monete che vengono lanciate 100 volte. 
Visualizzare quante  volte nell’esperimento si presenta “testa” un numero di volte pari a 0,1,2,3.  
'''

import random

nsimulazione = 100

eventi = [(random.randint(0,1) + random.randint(0,1) + random.randint(0,1)) for x in range(nsimulazione)]

moneta = {}
probabilita = {}

for lancio in eventi:
        try:
            moneta[lancio] += 1
        except KeyError:
            moneta[lancio] = 1

totProve = sum(moneta.values())

for lancio in eventi:
    probabilita[lancio] = moneta[lancio] / totProve

#Trasformo il dizionario in una lista di coppie di tuple per ordinare i casi partendo dal caso 0
monetaOrdianta = sorted(moneta.items())
probabilitaOrdinata = sorted(probabilita.items())

print("\n 0 -> 3 monete sono croce\n 1 -> 1 monete testa e 2 croce\n 2 -> 2 monete testa e 1 croce\n 3 -> monete testa\n")
print("Casi: ", monetaOrdianta, "Numero prove: ", totProve)
print("La probabilità di questi casi è: ", probabilitaOrdinata, sum(probabilita.values()))

