/*Dato in input un numero positivo n, stampare i soli numeri dispari minori
uguali di n e maggiori di zero.(n=6 -> 5 3 1)*/

using System;

namespace Es_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, resto = 0, num = 0; //numeri = 0;

            do
            {
                Console.WriteLine("Inserire il numero?");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);

            num = n;
            Console.WriteLine("I numeri sono:");

            for (int i = 0; i < n; i++)
            {
                num = num - 1;
                resto = num % 2;

                if (resto == 0)
                {
                }
                else
                {
                    Console.WriteLine(num);
                    //numeri = (numeri * 10) + num;
                }
            }

            //Console.WriteLine("La serei di numeri descrescenti e dispari del numero: " + n);
            //Console.WriteLine(numeri);
            Console.Read();
        }
    }
}
