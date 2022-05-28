import {Aeromobile} from "./aeromobile"

//Creazione interaccia ICompare
export interface ICompare {
   Superiore(aeromobile: Aeromobile) : boolean;
}
