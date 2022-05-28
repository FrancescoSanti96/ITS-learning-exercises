"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const quadro_1 = require("./quadro");
const scultura_1 = require("./scultura");
const collezione_1 = require("./collezione");
//Istanzio i quadri
var quadro1 = new quadro_1.Quadro("Guernica", "Picasso", 8, 8);
var quadro2 = new quadro_1.Quadro("Autoritratto", "Picasso", 10, 10);
//Istnazio le sculture
var scultura1 = new scultura_1.Scultura("David di Michelangelo", "Michelangelo", 50, 80, 40);
var scultura2 = new scultura_1.Scultura("Superman", "Francesco", 30, 40, 80);
var scultura3 = new scultura_1.Scultura("Batman", "Andrea", 25, 25, 47);
// Creo la collezione 
var sf = new collezione_1.Collezione("Amaita", "Santa Fiora", [quadro1, scultura2, scultura3]);
// prova dei metodi della collezione
console.log("prova dei metodi della collezione ");
sf.StampaOccupazioneOpera(quadro1);
sf.StampaOccupazioneOpera(scultura2);
sf.stampaCollezione();
sf.inserireOpera(scultura1);
sf.stampaCollezione();
// prova equals
console.log("\nprova equals");
console.log(quadro2.equals(quadro2, scultura2));
console.log(quadro2.equals(quadro2, quadro2));
console.log(quadro2.equals(quadro2, null));
//# sourceMappingURL=index.js.map