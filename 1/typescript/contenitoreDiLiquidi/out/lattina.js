"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Lattina = void 0;
const contenitore_1 = require("./contenitore");
const bidone_1 = require("./bidone");
class Lattina extends contenitore_1.Contenitore {
    constructor(codice, liquido, quantità, pesoCampione) {
        super(codice, liquido, quantità, pesoCampione);
        this.pesoTotale = 0;
    }
    //Ogni volta che istanzio un nuovo contenitore lattina devo andare a calcolarne il peso
    //che poi utilizzero per poter effetuare il confronto usando l'iterfaccia ICompare
    calcolaPeso() {
        this.pesoTotale = super.numero * super.peso;
        console.log("Il peso totale della lattina è: " + this.pesoTotale);
    }
    //Creazione interaccia ICompare
    maggiore(contenitore) {
        //considero il caso in cui comparo una lattina con un bidone in cui da specifica deve sepre dare vero
        var risultato;
        console.log("Controllo per vedere se la lattina è maggiore: ");
        if (contenitore instanceof bidone_1.Bidone) {
            risultato = false;
        }
        else if (contenitore instanceof Lattina) {
            risultato = this.pesoTotale > contenitore.peso * contenitore.numero ? true : false;
        }
        return risultato;
    }
}
exports.Lattina = Lattina;
//# sourceMappingURL=lattina.js.map