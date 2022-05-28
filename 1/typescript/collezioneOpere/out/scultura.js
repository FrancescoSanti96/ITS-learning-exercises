"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Scultura = void 0;
//La sottoclasse scultura ha 3 variabili aggiuntive altezza larghezza e profondità che identificano le misure della scultura.
const opera_1 = require("./opera");
class Scultura extends opera_1.Opera {
    constructor(titolo, artista, altezza, larghezza, profondità) {
        super(titolo, artista);
        this.altezza = altezza;
        this.larghezza = larghezza;
        this.profondità = profondità;
    }
    //Implemento ingombro obbligatori perchè figlia di opera
    ingombro() {
        return (this.altezza * this.larghezza) * this.profondità;
    }
}
exports.Scultura = Scultura;
//# sourceMappingURL=scultura.js.map