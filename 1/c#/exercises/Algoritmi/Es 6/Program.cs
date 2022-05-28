/*Dati due numeri positivi n e m, calcolare quoziente e resto della divisione
n/m. (n=5,m=2 -> 5-2=3 -> 3-2 -> 1 ris=2 rest=1)*/

using System;

namespace Es_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, m = 0, divisione = 0, resto = 0;
           
            do
            {
                Console.WriteLine("Inserire il numero 1 e poi il numero 2: ");
                n = int.Parse(Console.ReadLine());
                m = int.Parse(Console.ReadLine());
            } while (n < 0 || m <= 0);

            resto = n;

            while (resto >= m)
            {
                resto = resto - m;
                divisione = divisione + 1;
            }
                Console.WriteLine("Il risultato della divisone è: ");
                Console.WriteLine(divisione);
                Console.WriteLine("Il resto della divisone è: ");
                Console.WriteLine(resto);
        }
    }
}
