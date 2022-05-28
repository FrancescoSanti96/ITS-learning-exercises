"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Aeromobile = void 0;
class Aeromobile {
    constructor(siglaIdeintificativa) {
        this.siglaIdentificativa = siglaIdeintificativa;
    }
    //get pubblico per accedere in lettura al valore della sigla identificativa
    get identificativoAereomobile() {
        return this.siglaIdentificativa;
    }
    //Utilizzo interfaccia ICompare per controllare se areomobile è nullo
    //In tal caso da specifica deve restituire false
    Superiore(aeromobile) {
        return aeromobile !== null ? true : false;
    }
}
exports.Aeromobile = Aeromobile;
//# sourceMappingURL=aeromobile.js.map