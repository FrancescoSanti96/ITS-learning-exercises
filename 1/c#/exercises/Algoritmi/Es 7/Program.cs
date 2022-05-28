/*Dato in input un numero n positivo, contare da quante cifre pari e dispari
è composto. (es. 123 -> 1 pari e 2 dispari)*/

using System;

namespace Es_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, pari = 0, dispari = 0, ris = 0, rest = 0, i = 0;

            do
            {
                Console.WriteLine("Inserire il numero: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);

            if (n == 0)
            {
                pari += 1;
            }
            else
            {
                i = n;

                while (i > 0)
                {
                    ris = i / 10;
                    rest = i % 10;

                    if (rest % 2 == 0)
                    {
                        pari += 1;
                    }
                    else
                    {
                        dispari += 1;
                    }

                    i = ris;
                }
            }
             Console.WriteLine("Il numero è composto da: ");
             Console.WriteLine(pari + " Cifre pari");
             Console.WriteLine(dispari + " Cifre dispari");
        }
    }
}
