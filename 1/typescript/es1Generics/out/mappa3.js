"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Mappa = void 0;
class Mappa {
    // private mappa : Map<any, any>;
    constructor(parola, codice) {
        this.parola = parola;
        this.codice = codice;
    }
    generaMappa() {
        var mappa = new Map();
        for (var i = 0; i < this.parola.length; i++) {
            mappa.set([this.parola[i]], [this.codice[i]]);
        }
        console.log(mappa);
    }
}
exports.Mappa = Mappa;
//# sourceMappingURL=mappa3.js.map