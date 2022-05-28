// Realizzare poi, una classe collezione identificata da un nome e da un insieme di opere d'arte e scrivere metodi che 
// siano in grado di: inserire l'opera d'arte, stampare la collezione , stampare l'occupazione di una data opera

import {Opera} from "./opera"
import {Quadro} from "./quadro"
import {Scultura} from "./scultura"

export class Collezione{

    private nomeCollezione:string;
    private luogo:string;
    private opere:Array<Opera>

    constructor(nomeCollezione:string, luogo:string, opere:Array<Opera>){
       this.nomeCollezione = nomeCollezione;
       this.luogo = luogo;
       this.opere = opere;
    }

    //Permette di inserire un opera che sia un quadro o una scultura alla nostra collezione
    public inserireOpera(opera: Quadro | Scultura) :void{
        this.opere.push(opera);
    }

    //Stampa la collezione di quadri e sculture della nostra collezione creata
    public stampaCollezione() :void{
        console.log("\nStampo collezione opere di: " + this.nomeCollezione)
        for(var i = 0; i < this.opere.length; i++)
        { 
            console.log(this.opere[i]); // output
        }
    }

    //Stampa l'ingombro dell'opera che sia un quadro o una scultura
    public StampaOccupazioneOpera(opera: Quadro | Scultura) :void{
        console.log("Stampo ingombro opera: " + opera.nomeOpera);

        if(opera instanceof Quadro) 
        { console.log(opera.ingombro());}
        else if(opera instanceof Scultura) 
        {console.log(opera.ingombro());}
    }

}