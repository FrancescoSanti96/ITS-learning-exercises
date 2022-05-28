//Dato in input un numero n, stampare i divisori primi di n.

using System;

namespace Es_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, rest = 0, rest2 = 0;

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
                    for (int e = n - 1; e > 1; e--)
                    {
                        rest2 = i % e;

                        if (rest2 == 0)
                        {
                            Console.WriteLine("Il numero: " + i + " è  un divisore primo di: " + n);
                            e = 0;
                        }
                    }
                }
            }
        }
    }
}
