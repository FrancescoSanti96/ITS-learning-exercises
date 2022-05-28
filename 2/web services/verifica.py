# Verifica finale 
import flask
import json
import time
import requests
from datetime import datetime
from pymongo import MongoClient

app = flask.Flask(__name__)

# Es1
@app.route("/apiFinale/es1")
def es1():
    return "<p>Buon anno per tutto l'anno!!!!!</p>"

# Es 2
@app.route("/apiFinale/es2" , methods = ['POST']) 
def es2():
    dati = flask.request.get_json()
    risultato = { "quoziente": dati["n1"] / dati["n2"] , "resto": dati["n1"] % dati["n2"] }
    return risultato

# Es 3
# Stringa di INPUT invertita. Es. se INPUT = ciao dovremo avere OUTPUT = oaic
@app.route("/apiFinale/es3" , methods = ['POST']) 
def es3():
    dati = flask.request.get_json()
    Stringa = dati["Stringa"][::-1]
    # count = len([lettera for lettera in stringa if lettera in 'aeiou'])
    # risultato = stringa * count
    return Stringa

# Es 4
# Palindromo o non palindromo
@app.route("/apiFinale/es4" , methods = ['POST']) 
def es4():
    dati = flask.request.get_json()
    # risultato = ""
    # Stringa = dati["Stringa"]
    # if(Stringa == Stringa[::-1]):
    #     risultato = "Palindromo"
    # else:
    #     risultato = "Non palindromo"
    risultato = "Palindromo" if dati["Stringa"] == dati["Stringa"][::-1] else "Non palindromo"
    return risultato

# Es 5
# Stringa: Ciao utente nomePersona cognomePersona
@app.route("/apiFinale/es5" , methods = ['POST']) 
def es5():
    dati = flask.request.get_json()
    return "Ciao utente " + dati["nome"] + " "  + dati["cognome"]

# Es 6
@app.route("/apiFinale/es6" , methods = ['POST'])
def es6(): 
    contatore = 0
    risultato = []
    dati = flask.request.get_json()
    playload = {'id': dati["idCitta"], 'appid': ''}

    while(contatore < 5):
        res = requests.get('http://api.openweathermap.org/data/2.5/weather', params=playload)

        now = datetime.now()
        current_time = now.strftime("%d-%m-%Y-%H:%M:%S")

        valori = {'idCitta':dati["idCitta"] , 'ora': current_time , 'temperatura': round(res.json()["main"]["temp"]-273.15 , 2)}
        risultato.append(valori)

        time.sleep(dati["tempo"])
        contatore += 1

    f =  open('dati.json', 'w')
    json.dump(risultato , f , indent=2)
    return "Salvataggio in corso controllare il file dati.json per visualizzare i dati."

# Es 7
@app.route("/apiFinale/es7" , methods = ['POST'])
def es7(): 
    client = MongoClient("mongodb://localhost:27017")
    db = client.verifica
    coll = db.temperatura

    contatore = 0
    dati = flask.request.get_json()
    playload = {'id': dati["idCitta"], 'appid': ''}

    while(contatore < 5):
        res = requests.get('http://api.openweathermap.org/data/2.5/weather', params=playload)

        now = datetime.now()
        current_time = now.strftime("%d-%m-%Y-%H:%M:%S")

        coll.insert_one({'idCitta':dati["idCitta"] , 'ora': current_time , 'temperatura': round(res.json()["main"]["temp"]-273.15 , 2)})

        time.sleep(dati["tempo"])
        contatore += 1

    return "Salvataggio in corso controllare il file database per visualizzare i dati."

# Es8
@app.route("/apiFinale/es8" , methods = ['POST'])
def es8(): 
    dati = flask.request.get_json()
    
    tabella = {"piede": ["24.5", "25" , "25" , "25.5"], "usa" : ["6", "6.5" , "7", "7.5"], "eu" : ["38.5", "39" , "40", "40.5"], "uk" : ["5.5", "6" , "6", "6.5"]}

    tagliaPartenza = tabella[dati["da"]].index(dati["taglia"])
    tagliaConvertita = tabella[dati["a"]][tagliaPartenza]

    risultato = { "da": dati["da"], "a": dati["a"], "tagliOriginale": dati["taglia"], "tagliConvertita": tagliaConvertita }
    return risultato

 