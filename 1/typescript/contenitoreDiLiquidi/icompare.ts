import{Bidone} from "./bidone"
import { Contenitore } from "./contenitore"
import{Lattina} from "./lattina"

//Creazione interaccia ICompare per confrontare i contenitori omologhi
export interface ICompare {
    maggiore(contenitore: Contenitore) : boolean;
 }