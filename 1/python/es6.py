'''
 Il file dvd.json è formato come segue:  
{  
 [  
 {  
 “nome”: “nomeArtista1”,  
 “genere”: “nomeGenere1”  
 },  
 …  
 {  
 “nome”: “nomeArtistaN”,  
 “genere”: “nomeGenereN”  
 }  
 ]  
}  
Visualizzare in output l’elenco dei DVD ordinati per nome.  
'''

import json

fp = open("dataEs6/dvd.json","r")
dvd = json.load(fp)

ordinamento = lambda persona: persona["nome"]
dvd.sort(key=ordinamento)

#Salvo i dvd ordinati in un apposito file .json
fp2 = open("dataEs6/dvdOrdinati.json", "w")
json.dump(dvd, fp2)

print(dvd)

fp.close()
fp2.close()
