import {ICompare} from "./ICompare";

export abstract class Aeromobile implements ICompare{

    private siglaIdentificativa:string;
    
    constructor(siglaIdeintificativa:string){
        this.siglaIdentificativa = siglaIdeintificativa;
    }

    //get pubblico per accedere in lettura al valore della sigla identificativa
    get identificativoAereomobile() :string {
        return this.siglaIdentificativa;
    }

    //Utilizzo interfaccia ICompare per controllare se areomobile è nullo
    //In tal caso da specifica deve restituire false
    Superiore(aeromobile: Aeromobile): boolean {
        return aeromobile !== null ? true : false;
    }

}