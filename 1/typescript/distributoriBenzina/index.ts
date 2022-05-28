import {Distributore} from "./distributore";
import {Pompa} from "./pompa";

//Distibutore Castel del piano piccolo con solo 1 pompa
var cp:Distributore = new Distributore("Castel del piano","Francesco","ENI",100);
var pompacp1:Pompa = new Pompa(cp,"Pompa numero 1");

//Distibutore Santa Fiora con 2 pompe
var sf:Distributore = new Distributore("Santa Fiora","Andrea","ESSO",150);
var pompasf1:Pompa = new Pompa(sf,"Pompa numero 1");
var pompasf2:Pompa = new Pompa(sf,"Pompa numero 2");

//Utilizzo interfaccia icompare per confrontare i distributori in base al serbatoio
console.log(sf.confrontoDistributori(cp));

// Rifornimento del serbatoio di CP di 50 e controllo giacenza totale
cp.approvigionamento(50);
cp.giacenzaCarburante();

//Erogazione pompa numero 1 castel del piano e gestione incassi della pompa
pompacp1.erogazione(30);
pompacp1.gestioneIncassi();

//Eogazione pompa numero 1 santa fiora e gestione incassi della pompa
pompasf1.erogazione(50);
pompasf1.gestioneIncassi();

//Erogazione pompa numero 2 santa fiora e gestione incassi della pompa
pompasf2.erogazione(10);
pompasf2.gestioneIncassi();

//Controllo totale degli incassi del distributore di Santa Fiora
sf.totaleIncassiDistributore();

//Utilizzo interfaccia icompare per confrontare i distributori in base al serbatoio 
console.log(sf.confrontoDistributori(cp));