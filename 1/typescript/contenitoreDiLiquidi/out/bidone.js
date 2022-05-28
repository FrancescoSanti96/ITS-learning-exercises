"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Bidone = void 0;
const contenitore_1 = require("./contenitore");
const lattina_1 = require("./lattina");
class Bidone extends contenitore_1.Contenitore {
    constructor(codice, liquido, quantità, pesoCampione) {
        super(codice, liquido, quantità, pesoCampione);
        this.pesoTotale = 0;
    }
    //Ogni volta che istanzio un nuovo contenitore bidone devo andare a calcolarne il peso
    //che poi utilizzero per poter effetuare il confronto usando l'iterfaccia ICompare
    calcolaPeso() {
        this.pesoTotale = super.numero * super.peso;
        console.log("Il peso totale del bidone è: " + this.pesoTotale);
    }
    //Creazione interaccia ICompare
    maggiore(contenitore) {
        //considero il caso in cui comparo un bidone con un lattina in cui da specifica deve sepre dare vero
        var risultato;
        console.log("Controllo per vedere se il bidone è maggiore: ");
        if (contenitore instanceof lattina_1.Lattina) {
            risultato = true;
        }
        else if (contenitore instanceof Bidone) {
            risultato = this.pesoTotale > contenitore.peso * contenitore.numero ? true : false;
        }
        return risultato;
    }
}
exports.Bidone = Bidone;
//# sourceMappingURL=bidone.js.map