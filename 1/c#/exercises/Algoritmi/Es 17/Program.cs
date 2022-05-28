/*Letto un numero intero positivo n, scrivere se il numero è
"palindromo".(es. 121 -> 121)*/

using System;

namespace Es_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, div = 0, rest = 0, num = 0;

            do
            {
                Console.WriteLine("Inserire il numero: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            div = n;

            while (div > 0)
            {
                rest = div % 10;
                div = div / 10;
                num = (num * 10) + rest;
            }

            if (num == n)
            {
                Console.WriteLine("Il numero: " + n +" è palindromo");
            }
            else
            {
                Console.WriteLine("Il numero: " + n + " non è palindromo");
            }

            Console.Read();
        }
    }
}
