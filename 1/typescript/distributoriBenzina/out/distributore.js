"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Distributore = void 0;
class Distributore {
    constructor(città, proprietario, marca, serbatoio) {
        this.totaleIncasso = 0;
        this.città = città;
        this.proprietario = proprietario;
        this.marca = marca;
        this.serbatoio = serbatoio;
    }
    // serve per gestire l'erogazione e diminuire la quantità del serbatoio in base all'erogazione della pompa
    gestioneSerbatio(quantità) {
        this.serbatoio = this.serbatoio - quantità;
        console.log("\nDistributore di " + this.città + ", la quantità di carburante rimanente è: " + this.serbatoio + "litri.");
    }
    // serve per fare il rifornimento del carburante
    approvigionamento(quantità) {
        this.serbatoio = this.serbatoio + quantità;
        console.log("\nDistributore di " + this.città + ", approvigionamento di: " + quantità + "litri, la quantità totale di carburante nel serbatio è: " + this.serbatoio + "litri.");
    }
    //Serve per poter vedere la giacenza totale del carburante
    giacenzaCarburante() {
        console.log("\nDistributore di " + this.città + ", la quantità totale di carburante nel serbatio è: " + this.serbatoio + "litri.");
    }
    // Gestisce in automatico per ogni erogazione la cassa totale del distributore
    incassiDistributore(incassoDallaPompa) {
        this.totaleIncasso = this.totaleIncasso + incassoDallaPompa;
    }
    // Mostra il totale degli incassi del distributore
    totaleIncassiDistributore() {
        console.log("\nDistributore di " + this.città + ", ll totale degli incassi è: " + this.totaleIncasso + " euro.");
    }
    //Gestione interfaccia
    confrontoDistributori(distributore) {
        console.log("\nIl distributore di: " + this.città + " è maggiore di: " + distributore.città + ".");
        return this.serbatoio > distributore.serbatoio ? true : false;
    }
}
exports.Distributore = Distributore;
//# sourceMappingURL=distributore.js.map