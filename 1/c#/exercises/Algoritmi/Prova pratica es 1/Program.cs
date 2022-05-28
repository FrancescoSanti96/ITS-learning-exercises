//Es 1.

/*Mi sono voluto divertire creando le 2 variabili persona e sconto, in teoria avrei potuto inserire
 un Console.WriteLine(""); all'interno dei condizionali senza dover creare le variabili 
per specificare la percentuale di sconto ed il cliente in che gruppo appartiene. */

using System;

namespace Prova_pratica_es_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int eta = 0;
            double soldi = 0, pagare = 0, sconto = 0;
            string persona = "";

            do
            {
                Console.WriteLine("Inserire l'età della persona: ");
                eta = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            } while (eta < 0);
           
            do
            {
                Console.WriteLine("Inserire il totale da pagere: ");
                soldi = double.Parse(Console.ReadLine());
                Console.WriteLine("");
            } while (soldi < 0);

            if (eta < 18)
            {
                persona = "minorenne";
                sconto = 5;
                pagare = (soldi - ((sconto * soldi) / 100));
            }            
            else if (eta < 60)
            {
                persona = "maggiorenne";
                sconto = 15;
                pagare = (soldi - ((sconto * soldi) / 100));
            }
            else
            {
                persona = "over 60";
                sconto = 30;
                pagare = (soldi - ((sconto * soldi) / 100));
            }

            Console.WriteLine("Il totale da pagare è: " + pagare + " euro, lo sconto applicato è del: " + sconto + "%, perchè il cliente è: " + persona);
            Console.ReadLine();
        }
    }
}
