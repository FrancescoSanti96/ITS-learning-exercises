import {Lista} from "./lista"

//Creo la mappa 
var ageMapping = new Map<string,number>();  

// Inserisco i valori all'interno della mappa contente nome e età
ageMapping.set("Francesco", 24);  
ageMapping.set("Andrea", 30);  
ageMapping.set("Maggie", 5);   

//istanzio una classe Lista che prende in ingresso un array di numeri e una mappa(string,number)
var prova: Lista<number,string,number> = new Lista<number,string,number>([1,2],ageMapping);

//Creo un array 
prova.generaArray();