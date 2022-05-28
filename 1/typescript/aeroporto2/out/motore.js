"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Motore = void 0;
const aeromobile_1 = require("./aeromobile");
//Creazione classe figlia di Aeromobile
class Motore extends aeromobile_1.Aeromobile {
    constructor(sigla, potenza) {
        super(sigla);
        this.potenza = potenza;
    }
    //get pubblico per accedere in lettura al valore della potenza in cavalli dell'aero a motore
    get potenzaCV() {
        return this.potenza;
    }
    //Utilizzo interfaccia ICompare per comparare 2 aerei a motore,
    //aeromobile non deve essere null e deve essere un Motore
    Superiore(aeromobile) {
        return aeromobile !== null && aeromobile instanceof Motore ?
            this.potenzaCV > aeromobile.potenzaCV : false;
    }
}
exports.Motore = Motore;
//# sourceMappingURL=motore.js.map