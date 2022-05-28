//Classe Lista che in ingresso  può prendere un array generico dichiarato poi in index e idem per la Map
export class Lista<T,U,C>{
    private parola : Array<T>;
    private codice : Map<U,C>;

    constructor(parola: Array<T>,codice : Map<U,C>,){
        this.parola = parola;
        this.codice = codice;
    }

    //Genera un array contnete un Map in cui i vari valori dell'array sono la chaive della Map per intero
    //Come si può selezionare solo la coppia chaive valore in posizione 1 da una mappa?

    public generaArray() :void{
        var provaArray : Array<any> = new Array<any>();
        var mappa : Map<Array<T>, Map<U,C>> = new Map<Array<T>, Map<U,C>>();
        for (var i = 0; i < this.parola.length; i++) {
            provaArray.push(mappa.set([this.parola[i]],this.codice)); 
        }
        console.log(provaArray);
        
    }
}