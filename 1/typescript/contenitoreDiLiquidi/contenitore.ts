export abstract class Contenitore{

    private codice:number;
    private liquido:string;
    private quantità:number;
    private pesoCampione:number;
    

    constructor(codice:number, liquido:string, quantità:number, pesoCampione:number)
    {
        this.codice=codice;
        this.liquido=liquido;
        this.quantità=quantità;
        this.pesoCampione=pesoCampione;
    }

    //Utilizzo il get per poter leggere il valore dalla classi figlie
    get peso() : number{
        return this.pesoCampione;
    }
    get numero() : number {
        return this.quantità
    }

    //Mi occore per leggere il valore del liquido nella classe filtra
    get tipoLiquido() : string {
        return this.liquido
    }
    
    //Mi occore per leggere il nome per l'output più comprensibile del interaccia icompare
    get identità() : string {
        return this.identità
    }
}