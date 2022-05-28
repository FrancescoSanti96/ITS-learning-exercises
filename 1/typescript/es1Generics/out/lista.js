"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Lista = void 0;
class Lista {
    constructor(parola, codice) {
        this.parola = parola;
        this.codice = codice;
    }
    generaArray() {
        var provaArray = new Array();
        var mappa = new Map();
        for (var i = 0; i < this.parola.length; i++) {
            provaArray.push(mappa.set([this.parola[i]], this.codice));
        }
        console.log(provaArray);
    }
}
exports.Lista = Lista;
//# sourceMappingURL=lista.js.map