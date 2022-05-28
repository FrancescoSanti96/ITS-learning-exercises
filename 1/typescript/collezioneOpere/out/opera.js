"use strict";
// Radice della gerarchia è la classe astratta opera d'arte contenente :
// — i campi protetti titolo e artista
// — il costruttore
// — il metodo public abstract double ingombro() che restituisce l'ingombro dell'opera
// — il metodo public boolean equals(Object o) che verifica se due opere d'arte sono uguali
// ed altri metodi di interesse.
Object.defineProperty(exports, "__esModule", { value: true });
exports.Opera = void 0;
class Opera {
    constructor(titolo, artista) {
        this.titolo = titolo;
        this.artista = artista;
    }
    get nomeOpera() {
        return this.titolo;
    }
    //Controlla se le opere sono uguali
    equals(opera1, opera2) {
        var risultato;
        console.log("Le opere sono uguali: ");
        return opera1 === opera2 ? true : false;
    }
}
exports.Opera = Opera;
//# sourceMappingURL=opera.js.map