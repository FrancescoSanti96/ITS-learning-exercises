using System;

namespace Es_11_boolean
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

                Console.WriteLine("Hello World!");
        }
    }
}
