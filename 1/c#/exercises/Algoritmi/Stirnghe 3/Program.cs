/*Generare una frase casuale (non deve per forza avere un senso logico)
Es: Fsdads dsfedds errots? Gsdfzsf, fgahhsd!*/

using System;

namespace Stirnghe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int lun = 0;
            string parola, frase = "";

            do
            {
                Console.WriteLine("Inserisci una parola: ");
                parola = Console.ReadLine();
                lun = parola.Length;
            } while ((lun < 1) || (lun > 7));

        }
    }
}
