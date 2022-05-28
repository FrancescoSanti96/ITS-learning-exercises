//La sottoclasse scultura ha 3 variabili aggiuntive altezza larghezza e profondità che identificano le misure della scultura.
import {Opera} from "./opera"

export class Scultura extends Opera{

    private altezza:number;
    private larghezza:number;
    private profondità:number;

    constructor(titolo:string, artista:string, altezza:number, larghezza:number, profondità:number){
        super(titolo,artista)
        this.altezza = altezza;
        this.larghezza = larghezza;
        this.profondità = profondità;
    }

    //Implemento ingombro obbligatori perchè figlia di opera
    public ingombro():number{
        return (this.altezza * this.larghezza) * this.profondità;
    }
}