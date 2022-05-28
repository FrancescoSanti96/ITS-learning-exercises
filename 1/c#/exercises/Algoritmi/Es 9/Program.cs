/*Dato in input un numero n, stampare i divisori di n (tutti i numeri minori
di n che dividono n in modo intero)*/

using System;

namespace Es_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            do
            {
                Console.WriteLine("Inserire il numero: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            for (int i = n - 1; i > 1; i--)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i + " è un divisore intero di " + n);
                }
            }
        }
    }
}
