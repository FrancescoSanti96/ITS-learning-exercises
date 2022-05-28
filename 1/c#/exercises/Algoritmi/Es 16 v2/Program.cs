/*Leggere numeri interi in input e stampare solo quelli che creano una
sequenza crescente, con il numero zero l'algoritmo termina.
(es. 5(ok) 7(ok) 4(no) 9(ok) 1(no) 0(fine) -> output: 5 7 9 ).*/

using System;

namespace Es_16_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, last = 0;

            Console.WriteLine("Inserire il numero: ");
            n = int.Parse(Console.ReadLine());

            last = n - 1;

            while (n != 0)
            {
                if (n > last)
                {
                    Console.WriteLine("   " + n);
                    last = n;
                }

             Console.WriteLine("Inserire il numero: ");
             n = int.Parse(Console.ReadLine());
            }
        }
    }
}
