"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Dado = void 0;
const lancio_1 = require("./lancio");
class Dado extends lancio_1.Lancio {
    constructor() {
        super(1, 7);
    }
}
exports.Dado = Dado;
