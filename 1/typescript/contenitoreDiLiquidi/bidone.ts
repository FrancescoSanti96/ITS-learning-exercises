import {Contenitore} from "./contenitore"
import {Lattina} from "./lattina"
import {ICompare} from "./icompare"

export class Bidone extends Contenitore implements ICompare{
    
    
    private pesoTotale:number = 0;
    
    
    constructor(codice:number, liquido:string, quantità:number,pesoCampione:number){
        super(codice,liquido,quantità,pesoCampione);
    }

    //Ogni volta che istanzio un nuovo contenitore bidone devo andare a calcolarne il peso
    //che poi utilizzero per poter effetuare il confronto usando l'iterfaccia ICompare
    public calcolaPeso():void{
        this.pesoTotale = super.numero * super.peso;
        console.log("Il peso totale del bidone è: " +this.pesoTotale);
    }

    //Creazione interaccia ICompare
    maggiore(contenitore: Bidone | Lattina) : boolean
    {
        //considero il caso in cui comparo un bidone con un lattina in cui da specifica deve sepre dare vero
        var risultato: boolean;
        console.log("Controllo per vedere se il bidone è maggiore: ");
        if(contenitore instanceof Lattina) 
        { risultato = true; }
        else if(contenitore instanceof Bidone) 
        {risultato = this.pesoTotale > contenitore.peso*contenitore.numero ? true: false;}
        return risultato;
    }
}