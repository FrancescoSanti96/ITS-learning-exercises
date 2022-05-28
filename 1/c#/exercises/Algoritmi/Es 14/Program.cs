/*Dato un numero intero positivo in input, sommare tutte le sue cifre
riducendolo ad una sola cifra.(es. 123 -> 6)*/

using System;

namespace Es_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, ris, rest, somma = 0; 

            do
            {
                Console.WriteLine("Inserire il numero: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            for (int i = n; i >= 10;)
            {
                ris = 0;
                rest = 0;
                somma = 0;

                do
                {
                    ris = i / 10;
                    rest = i % 10;
                    somma = somma + rest;
                    i = ris;
                } while (i > 0);

                i = somma;
            }

            Console.WriteLine("Il risultato è: " + somma);
            Console.Read();
        }
    }
}
