import {Aeromobile} from "./aeromobile"
import {ICompare} from "./ICompare";

//Creazione classe figlia di Aeromobile
export class Motore extends Aeromobile implements ICompare{
    
    private potenza: number;
    
    constructor(sigla: string, potenza: number){
        super(sigla);
        this.potenza = potenza;
    }

    //get pubblico per accedere in lettura al valore della potenza in cavalli dell'aero a motore
    get potenzaCV() : number {
        return this.potenza;
    }

    //Utilizzo interfaccia ICompare per comparare 2 aerei a motore,
    //aeromobile non deve essere null e deve essere un Motore
    Superiore(aeromobile: Aeromobile): boolean {
        return aeromobile !== null && aeromobile instanceof Motore ? 
        this.potenzaCV > aeromobile.potenzaCV : false;
    }
}