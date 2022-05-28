"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Aliante = void 0;
const aeromobile_1 = require("./aeromobile");
//Creazione classe figlia Aliante di Aeromobile
class Aliante extends aeromobile_1.Aeromobile {
    constructor(sigla, efficienza) {
        super(sigla);
        this.efficienza = efficienza;
        //this.tipologia = tipologia;
    }
    //get pubblico per accedere in lettura al valore dell'efficienza aereodinamica dell'Aliante
    get efficienzaAereodinamica() {
        return this.efficienza;
    }
    //Utilizzo interfaccia ICompare per comparare 2 aerei aliante,
    //aeromobile non deve essere null e deve essere un Aliante
    Superiore(aeromobile) {
        return aeromobile !== null && aeromobile instanceof Aliante ?
            this.efficienzaAereodinamica > aeromobile.efficienzaAereodinamica : false;
    }
}
exports.Aliante = Aliante;
//# sourceMappingURL=aliante.js.map