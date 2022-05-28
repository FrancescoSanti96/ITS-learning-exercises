export abstract class Lancio {

    minimo:number;
    massimo:number;

    constructor(minimo: number, massimo: number) {
        this.minimo = minimo;
        this.massimo = massimo;
    }

    public lanciare():number {
        return Math.floor(Math.random() * (this.massimo - this.minimo) ) + this.minimo;
    }

}