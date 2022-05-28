// Radice della gerarchia è la classe astratta opera d'arte contenente :
// — i campi protetti titolo e artista
// — il costruttore
// — il metodo public abstract double ingombro() che restituisce l'ingombro dell'opera
// — il metodo public boolean equals(Object o) che verifica se due opere d'arte sono uguali
// ed altri metodi di interesse.

export abstract class Opera {
    private titolo:string;
    private artista:string;

    constructor(titolo:string, artista:string){
        this.titolo=titolo;
        this.artista=artista;
    }
    
    get nomeOpera() : string {
        return this.titolo
    }

    public abstract ingombro():number;

    //Controlla se le opere sono uguali
    public equals(opera1: Opera, opera2: Opera): boolean{
        var risultato: boolean;
        console.log("Le opere sono uguali: ");
        return opera1 === opera2 ? true: false;
    }
}