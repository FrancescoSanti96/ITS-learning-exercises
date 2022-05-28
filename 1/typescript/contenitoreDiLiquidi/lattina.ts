import {Contenitore} from "./contenitore"
import {Bidone} from "./bidone"
import {ICompare} from "./icompare"

export class Lattina extends Contenitore implements ICompare{
    
    
    private pesoTotale:number = 0;
    
    
    constructor(codice:number, liquido:string, quantità:number,pesoCampione:number){
        super(codice,liquido,quantità,pesoCampione);
    }

    //Ogni volta che istanzio un nuovo contenitore lattina devo andare a calcolarne il peso
    //che poi utilizzero per poter effetuare il confronto usando l'iterfaccia ICompare
    public calcolaPeso():void{
        this.pesoTotale = super.numero * super.peso;
        console.log("Il peso totale della lattina è: " +this.pesoTotale);
    }

    //Creazione interaccia ICompare
    maggiore(contenitore: Lattina | Bidone) : boolean
    {
        //considero il caso in cui comparo una lattina con un bidone in cui da specifica deve sepre dare vero
        var risultato: boolean;
        console.log("Controllo per vedere se la lattina è maggiore: ");
        if(contenitore instanceof Bidone) 
        {risultato = false;}
        else if(contenitore instanceof Lattina) 
        { risultato = this.pesoTotale > contenitore.peso*contenitore.numero ? true: false; }
        return risultato;
    }

}