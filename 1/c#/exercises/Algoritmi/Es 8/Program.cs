/*Dati in input b e p calcolare l'elevamento a potenza di b alla p.
Esempio: b=4, p=3 -> b^p = 4*4*4 = 64*/

//non è calcolato correttamento 0 ^ 0

using System;

namespace Es_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, m = 0, ris = 1;

            do
            {
                Console.WriteLine("Inserire il numero 1 e poi il numero 2: ");
                n = int.Parse(Console.ReadLine());
                m = int.Parse(Console.ReadLine());
            } while (n < 0 || m < 0);

            for (int i = 0; i < m; i++)
            {
                ris = ris * n;
            }
            Console.WriteLine("Il risultato è: ");
            Console.WriteLine(ris);
        }
    }
}
