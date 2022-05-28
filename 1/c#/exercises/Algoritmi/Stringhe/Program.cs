//Es1 slide 8 Fornita una parola in input, dire se è palindroma
using System;

namespace Stringhe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lun = 0;
            string parola, parolainversa = "";
            do
            {
                Console.WriteLine("Inserisci una parola: ");
                parola = Console.ReadLine();
                lun = parola.Length;
            } while ((lun < 1) || (lun > 50));

            for (int i = lun - 1; i >= 0; i--)
            {
                parolainversa += parola[i];
            }

            if (parola == parolainversa)
            {
                Console.WriteLine("La parola è palidroma");
            }

            else
            {
                Console.WriteLine("La frase non è palindroma");
            }

            Console.WriteLine("");
            Console.ReadLine();

        }
    }
}
