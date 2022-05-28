import {Distributore} from "./distributore"

//Creazione interaccia ICompare
export interface ICompare {
   confrontoDistributori(distributore: Distributore) : boolean;
}