import {Distributore} from "./distributore";

export class Pompa{
    private nomeDistributore:Distributore;
    private identificativo:string;
    private gestioneIncasso:number = 0;

    constructor (nomeDistributore:Distributore, identificativo:string)
    {
        this.nomeDistributore=nomeDistributore;
        this.identificativo=identificativo;
    } 

    //Serve per poter fare l'erogazione del carburante dalla pompa selezionata
    public erogazione(quantità:number): void
    {
    this.nomeDistributore.gestioneSerbatio(quantità); //gestione serbatoio
    this.gestioneIncasso = this.gestioneIncasso + (quantità*1.5);
    this.nomeDistributore.incassiDistributore(this.gestioneIncasso);
    }

    //Fornisce l'incassi percepiti dall'erogazione della pompa selezionata
        public gestioneIncassi(): void
    {
    console.log("L'incasso per la pompa: "+this.identificativo+", è di: " +this.gestioneIncasso + "Euro.")
    }

}