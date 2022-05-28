"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const distributore_1 = require("./distributore");
const pompa_1 = require("./pompa");
//Distibutore Castel del piano piccolo con solo 1 pompa
var cp = new distributore_1.Distributore("Castel del piano", "Francesco", "ENI", 100);
var pompacp1 = new pompa_1.Pompa(cp, "Pompa numero 1");
//Distibutore Santa Fiora con 2 pompe
var sf = new distributore_1.Distributore("Santa Fiora", "Andrea", "ESSO", 150);
var pompasf1 = new pompa_1.Pompa(sf, "Pompa numero 1");
var pompasf2 = new pompa_1.Pompa(sf, "Pompa numero 2");
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
//# sourceMappingURL=index.js.map