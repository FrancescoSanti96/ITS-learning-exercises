//Dato in input un numero n positivo, capire se il numero è primo.

using System;

namespace Es_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, rest = 0;

            do
            {
                Console.WriteLine("Inserire il numero: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            for (int i = n - 1; i > 1; i--)
            {
                rest = n % i;

                if (rest == 0)
                {
                    Console.WriteLine("Il numero non è primo");
                    i = 0;
                }
            }

            if (rest != 0)
            {
                Console.WriteLine("Il numero " + n + " è primo");
            }
        }
    }
}
