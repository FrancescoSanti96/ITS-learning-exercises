"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Lancio = void 0;
class Lancio {
    constructor(minimo, massimo) {
        this.minimo = minimo;
        this.massimo = massimo;
    }
    lanciare() {
        return Math.floor(Math.random() * (this.massimo - this.minimo)) + this.minimo;
    }
}
exports.Lancio = Lancio;
