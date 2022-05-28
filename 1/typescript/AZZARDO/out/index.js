"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const dado_1 = require("./dado");
const moneta_1 = require("./moneta");
var valoreDado = new dado_1.Dado();
var valoreMoneta = new moneta_1.Moneta();
console.log("Il valore del lancio del dado è: ", valoreDado.lanciare());
console.log("Il valore del lancio della moneta è: ", valoreMoneta.lanciare());
