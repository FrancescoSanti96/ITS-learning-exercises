/*Dato in input un numero positivo x e un numero positivo y, stampare tutti
i numeri compresi tra questi due in ordine crescente. (x=4, y = 8-> 5 6 7)*/

using System;

namespace Es_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, temp = 0;

            do
            {
                Console.WriteLine("Inserire il numero 1 e poi il numero 2 ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            } while (x < 0 || y < 0);

            if (x<y)
            {
                temp = y;
                y = x;
                x = temp;
            }
            else
            {
            }

            y = y + 1;
            Console.WriteLine("I numeri compresi sono: ");

            for (int i = y; i < x; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
