"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const motore_1 = require("./motore");
const aliante_1 = require("./aliante");
//Istanzio gli aereoplani della tiplogia Alianti
var aliante1 = new aliante_1.Aliante("123aliante", 2000);
var aliante2 = new aliante_1.Aliante("188aliante", 199);
//Istanzio gli aereoplani a motore propulsore
var motorePropulsore1 = new motore_1.Motore("12motorepot", 3000);
var motorePropulsore2 = new motore_1.Motore("12motore", 198);
//Utilizzo il metodo Superiore derivato dall'interfaccai ICompare per controllare se un aereoplano è più grande dell'altro
//Eseguendo le varie casistiche di prova richieste da specifica
console.log(aliante1.Superiore(null));
console.log(aliante1.Superiore(motorePropulsore2));
console.log(motorePropulsore1.Superiore(motorePropulsore2));
console.log(aliante1.Superiore(aliante2));
console.log(aliante2.Superiore(aliante1));
//# sourceMappingURL=index.js.map