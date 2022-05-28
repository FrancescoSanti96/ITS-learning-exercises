/*Dato in input un numero positivo n, stampare tutti i numeri minori uguali
di n fino a zero. (n=6 -> 6 5 4 3 2 1 0)*/

using System;

namespace Es_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, num = 0; // numeri = 0;

            do
            {
                Console.WriteLine("Inserire il numero?");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);

            num = n;
            Console.WriteLine("I numeri sono:");

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(num);
                //numeri = (numeri * 10) + num;
                num = num - 1;
            }

            //Console.WriteLine("La serei di numeri descrescenti del numero: " + n);
            //Console.WriteLine(numeri);
            Console.Read();

        }
    }
}
