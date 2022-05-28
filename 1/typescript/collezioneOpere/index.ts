import {Quadro} from "./quadro"
import {Scultura} from "./scultura"
import {Collezione} from "./collezione"

//Istanzio i quadri
var quadro1: Quadro = new Quadro("Guernica","Picasso",8,8);
var quadro2: Quadro = new Quadro("Autoritratto","Picasso",10,10);

//Istnazio le sculture
var scultura1 : Scultura = new Scultura("David di Michelangelo","Michelangelo",50,80,40);
var scultura2 : Scultura = new Scultura("Superman","Francesco",30,40,80);
var scultura3 : Scultura = new Scultura("Batman","Andrea",25,25,47);

// Creo la collezione 
var sf : Collezione = new Collezione("Amaita","Santa Fiora",[quadro1,scultura2,scultura3]);


// prova dei metodi della collezione

//Stampa l'occupazione dell'opera
sf.StampaOccupazioneOpera(quadro1);
sf.StampaOccupazioneOpera(scultura2);

//Stampa l'intera collezione
sf.stampaCollezione();

//Permette di aggiungere un opera alla collezzione
sf.inserireOpera(scultura1);

//Ristampo la collezione dopo aver aggiunto un opera
sf.stampaCollezione();


// prova equals, metodo generico di opera per fare un cotnrollo di ugualianza
console.log("\nprova equals");
console.log(quadro2.equals(quadro2,scultura2));
console.log(quadro2.equals(quadro2,quadro2));
console.log(quadro2.equals(quadro2,null));


