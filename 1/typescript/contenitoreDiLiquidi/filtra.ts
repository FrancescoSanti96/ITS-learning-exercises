import {Bidone} from "./bidone"
import {Contenitore} from "./contenitore"
import {Lattina} from "./lattina"

export class Filtra{
    
    
    private vettore:Array<Contenitore>;
    private contenitoreCampione: Contenitore;
    
    
    constructor(vettore:Array<Contenitore>,contenitoreCampione: Contenitore){
        this.vettore=vettore;
        this.contenitoreCampione=contenitoreCampione;
    }

    //Metodo filtrare come richesto nelle specifiche
    //Fornito in ingresso un array di contenitori e un capione di contenitore rimuove tutti quelli uguali
    public filtrare(): void{
        for(var i = 0; i < this.vettore.length; i++)
        { 
            if(this.vettore[i].tipoLiquido === this.contenitoreCampione.tipoLiquido){
                this.vettore.splice(i, 1);
                // decremeto la i per poter considerare tutti i casi altrimenti quando ne trovo uno vero
                // in pratica non considero quello subito dopò perchè eliminadolo l'altro prende il suo posto
                // all'interno dell'array e devo dunque decrementare la i per controllaro 
                //Nota: Inzialmente ho usato delete ma in output forniva un undefined
                i--;
            }
        }
         for(var i = 0; i < this.vettore.length; i++)
        { 
        console.log(this.vettore[i]);
        }
    }
    
}    