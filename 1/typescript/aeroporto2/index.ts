import {Motore} from "./motore"
import {Aliante} from "./aliante"

//Istanzio gli aereoplani della tiplogia Alianti
var aliante1: Aliante = new Aliante("123aliante", 2000);
var aliante2: Aliante = new Aliante("188aliante", 199);

//Istanzio gli aereoplani a motore propulsore
var motorePropulsore1: Motore = new Motore("12motorepot", 3000);
var motorePropulsore2: Motore = new Motore("12motore", 198);


//Utilizzo il metodo Superiore derivato dall'interfaccai ICompare per controllare se un aereoplano è più grande dell'altro
//Eseguendo le varie casistiche di prova richieste da specifica
console.log(aliante1.Superiore(null));
console.log(aliante1.Superiore(motorePropulsore2));
console.log(motorePropulsore1.Superiore(motorePropulsore2));
console.log(aliante1.Superiore(aliante2));
console.log(aliante2.Superiore(aliante1));
