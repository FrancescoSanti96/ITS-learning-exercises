using System;

namespace Es_16_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1, last = 0;

            while (n != 0)
            {
                Console.WriteLine("Inserire il numero: ");
                n = int.Parse(Console.ReadLine());

                if (n > last)
                {
                    Console.WriteLine("   " + n);
                    last = n;
                }


            }
        }
    }
}
