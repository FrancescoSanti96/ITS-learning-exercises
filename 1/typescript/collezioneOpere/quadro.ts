// La sottoclasse quadro ha due variabili aggiuntive:altezza e larghezza che identificano la misura del quadro.

import {Opera} from "./opera"

export class Quadro extends Opera{

    private altezza:number;
    private larghezza:number;

    constructor(titolo:string, artista:string, altezza:number, larghezza:number){
        super(titolo,artista)
        this.altezza = altezza;
        this.larghezza = larghezza;
    }
    
    //Implemento ingombro obbligatori perchè figlia di opera
    public ingombro():number{
        return (this.altezza*2) + (this.larghezza*2);
    }
}