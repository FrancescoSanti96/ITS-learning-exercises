"use strict";
// Realizzare poi, una classe collezione identificata da un nome e da un insieme di opere d'arte e scrivere metodi che 
// siano in grado di: inserire l'opera d'arte, stampare la collezione , stampare l'occupazione di una data opera
Object.defineProperty(exports, "__esModule", { value: true });
exports.Collezione = void 0;
const quadro_1 = require("./quadro");
const scultura_1 = require("./scultura");
class Collezione {
    constructor(nomeCollezione, luogo, opere) {
        this.nomeCollezione = nomeCollezione;
        this.luogo = luogo;
        this.opere = opere;
    }
    //Permette di inserire un opera che sia un quadro o una scultura alla nostra collezione
    inserireOpera(opera) {
        this.opere.push(opera);
    }
    //Stampa la collezione di quadri e sculture della nostra collezione creata
    stampaCollezione() {
        console.log("\nStampo collezione opere di: " + this.nomeCollezione);
        for (var i = 0; i < this.opere.length; i++) {
            console.log(this.opere[i]); // output
        }
    }
    //Stampa l'ingombro dell'opera che sia un quadro o una scultura
    StampaOccupazioneOpera(opera) {
        console.log("Stampo ingombro opera: " + opera.nomeOpera);
        if (opera instanceof quadro_1.Quadro) {
            console.log(opera.ingombro());
        }
        else if (opera instanceof scultura_1.Scultura) {
            console.log(opera.ingombro());
        }
    }
}
exports.Collezione = Collezione;
//# sourceMappingURL=collezione.js.map