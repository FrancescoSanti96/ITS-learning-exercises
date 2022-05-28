"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const bidone_1 = require("./bidone");
const lattina_1 = require("./lattina");
const filtra_1 = require("./filtra");
//Istanzio i contenitori bidone
var bidone1 = new bidone_1.Bidone(123, "bianco", 15, 10);
var bidone2 = new bidone_1.Bidone(144, "rosso", 9, 10);
var bidone3 = new bidone_1.Bidone(156, "bianco", 17, 10);
//Istanzio i contenitori lattina
var lattina1 = new lattina_1.Lattina(12, "coca cola", 5, 2);
var lattina2 = new lattina_1.Lattina(33, "fanta", 4, 1000);
//Calcolo il peso del bidone1 e del bidone2 necessario per poterli poi confrontare
bidone1.calcolaPeso();
bidone2.calcolaPeso();
bidone3.calcolaPeso();
//Calcolo il peso della lattina1 e della lattina2 necessario per poterli poi confrontare
lattina1.calcolaPeso();
lattina2.calcolaPeso();
//Confronto utilizzando ICompare i 4 cosi
//Bidone lattina sempre vero
console.log(bidone1.maggiore(lattina2));
//Lattina bidone sempre falso
console.log(lattina1.maggiore(bidone1));
//comparo 2 bidoni
console.log(bidone1.maggiore(bidone2));
//compare 2 latitne
console.log(lattina2.maggiore(lattina1));
//Creo un array da filtrare dal campione fornito in questo caso bidone1
var filtrare1 = new filtra_1.Filtra([bidone1, bidone2, lattina1, lattina2, bidone3], bidone1);
//Avvio il metodo per filtrare
filtrare1.filtrare();
//# sourceMappingURL=index.js.map