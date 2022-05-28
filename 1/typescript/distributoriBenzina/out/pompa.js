"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Pompa = void 0;
class Pompa {
    constructor(nomeDistributore, identificativo) {
        this.gestioneIncasso = 0;
        this.nomeDistributore = nomeDistributore;
        this.identificativo = identificativo;
    }
    //Serve per poter fare l'erogazione del carburante dalla pompa selezionata
    erogazione(quantità) {
        this.nomeDistributore.gestioneSerbatio(quantità); //gestione serbatoio
        this.gestioneIncasso = this.gestioneIncasso + (quantità * 1.5);
        this.nomeDistributore.incassiDistributore(this.gestioneIncasso);
    }
    //Fornisce l'incassi percepiti dall'erogazione della pompa selezionata
    gestioneIncassi() {
        console.log("L'incasso per la pompa: " + this.identificativo + ", è di: " + this.gestioneIncasso + "Euro.");
    }
}
exports.Pompa = Pompa;
//# sourceMappingURL=pompa.js.map