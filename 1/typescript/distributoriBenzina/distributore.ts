import {ICompare} from "./icompare"

export class Distributore implements ICompare{
    private città:string;
    private proprietario:string;
    private marca:string;
    private serbatoio:number;
    private totaleIncasso:number = 0;

    constructor (città:string, proprietario:string, marca:string, serbatoio:number)
    {
        this.città=città;
        this.proprietario=proprietario;
        this.marca=marca;
        this.serbatoio=serbatoio;
    }
    // serve per gestire l'erogazione e diminuire la quantità del serbatoio in base all'erogazione della pompa
    public gestioneSerbatio(quantità:number): void{
        this.serbatoio= this.serbatoio - quantità;
        console.log("\nDistributore di "+this.città+", la quantità di carburante rimanente è: " +this.serbatoio+"litri." )
    }

    // serve per fare il rifornimento del carburante
    public approvigionamento(quantità:number): void{
        this.serbatoio= this.serbatoio + quantità;
        console.log("\nDistributore di "+this.città+", approvigionamento di: " + quantità + "litri, la quantità totale di carburante nel serbatio è: " + this.serbatoio + "litri.")
    }

    //Serve per poter vedere la giacenza totale del carburante
    public giacenzaCarburante(): void{
        console.log("\nDistributore di "+this.città+", la quantità totale di carburante nel serbatio è: " + this.serbatoio + "litri.")
    }

    // Gestisce in automatico per ogni erogazione la cassa totale del distributore
    public incassiDistributore(incassoDallaPompa:number): void{
        this.totaleIncasso = this.totaleIncasso + incassoDallaPompa;
    }

    // Mostra il totale degli incassi del distributore
    public totaleIncassiDistributore(): void{
        console.log("\nDistributore di "+this.città+", ll totale degli incassi è: " +this.totaleIncasso+" euro.")
    }

    //Gestione interfaccia
    confrontoDistributori(distributore: Distributore) : boolean
    {
        console.log("\nIl distributore di: " + this.città + " è maggiore di: " + distributore.città + ".")
        return this.serbatoio > distributore.serbatoio ? true : false;
    }
}