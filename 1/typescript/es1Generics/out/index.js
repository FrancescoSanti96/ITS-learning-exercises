"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const lista_1 = require("./lista");
//Creo la mappa 
var ageMapping = new Map();
// Inserisco i valori all'interno della mappa contente nome e età
ageMapping.set("Francesco", 24);
ageMapping.set("Andrea", 30);
ageMapping.set("Maggie", 5);
//istanzio una classe Lista che prende in ingresso un array di numeri e una mappa(string,number)
var prova = new lista_1.Lista([1, 2], ageMapping);
//Creo un array 
prova.generaArray();
//# sourceMappingURL=index.js.map