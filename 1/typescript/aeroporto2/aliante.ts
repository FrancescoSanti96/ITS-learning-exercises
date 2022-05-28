import {Aeromobile} from "./aeromobile"
import {ICompare} from "./ICompare";

//Creazione classe figlia Aliante di Aeromobile
export class Aliante extends Aeromobile implements ICompare{

    private efficienza:number;
    
    constructor(sigla:string, efficienza:number){
        super(sigla);
        this.efficienza = efficienza;
        //this.tipologia = tipologia;
    }

    //get pubblico per accedere in lettura al valore dell'efficienza aereodinamica dell'Aliante
    get efficienzaAereodinamica() : number {
        return this.efficienza;
    }

    //Utilizzo interfaccia ICompare per comparare 2 aerei aliante,
    //aeromobile non deve essere null e deve essere un Aliante
    Superiore(aeromobile: Aeromobile): boolean {
        return aeromobile !== null && aeromobile instanceof Aliante ? 
        this.efficienzaAereodinamica > aeromobile.efficienzaAereodinamica : false;
    }
}