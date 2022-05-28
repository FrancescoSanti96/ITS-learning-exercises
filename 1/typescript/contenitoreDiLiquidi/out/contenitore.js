"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Contenitore = void 0;
class Contenitore {
    constructor(codice, liquido, quantità, pesoCampione) {
        this.codice = codice;
        this.liquido = liquido;
        this.quantità = quantità;
        this.pesoCampione = pesoCampione;
    }
    //Utilizzo il get per poter leggere il valore dalla classi figlie
    get peso() {
        return this.pesoCampione;
    }
    get numero() {
        return this.quantità;
    }
    //Mi occore per leggere il valore del liquido nella classe filtra
    get tipoLiquido() {
        return this.liquido;
    }
}
exports.Contenitore = Contenitore;
//# sourceMappingURL=contenitore.js.map