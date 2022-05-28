/*Dati due numeri positivi n e m, calcolare la loro moltiplicazione usando
solamente l'operatore di somma algebrica. ( n=3, m=4 -> 3+3+3+3 = 12)*/

using System;

namespace Es_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, m = 0, somma = 0;

            do
            {
                Console.WriteLine("Inserire il numero 1 e poi il numero 2: ");
                n = int.Parse(Console.ReadLine());
                m = int.Parse(Console.ReadLine());
            } while (n < 0 || m < 0);

            for (int i = 0; i < m; i++)
            {
                somma = somma + n;
            }
                Console.WriteLine("Il risultato della moltiplicazione è: ");
                Console.WriteLine(somma);
        }
    }
}
