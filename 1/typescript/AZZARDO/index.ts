import {Dado} from "./dado";
import {Moneta} from "./moneta";

var valoreDado: Dado = new Dado();
var valoreMoneta: Moneta = new Moneta();

console.log("Il valore del lancio del dado è: " , valoreDado.lanciare());
console.log("Il valore del lancio della moneta è: " , valoreMoneta.lanciare());