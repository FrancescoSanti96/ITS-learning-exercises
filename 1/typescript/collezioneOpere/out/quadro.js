"use strict";
// La sottoclasse quadro ha due variabili aggiuntive:altezza e larghezza che identificano la misura del quadro.
Object.defineProperty(exports, "__esModule", { value: true });
exports.Quadro = void 0;
const opera_1 = require("./opera");
class Quadro extends opera_1.Opera {
    constructor(titolo, artista, altezza, larghezza) {
        super(titolo, artista);
        this.altezza = altezza;
        this.larghezza = larghezza;
    }
    //Implemento ingombro obbligatori perchè figlia di opera
    ingombro() {
        return (this.altezza * 2) + (this.larghezza * 2);
    }
}
exports.Quadro = Quadro;
//# sourceMappingURL=quadro.js.map