using System;

namespace Funzioni_es_6_test_primarità
{
    class Program
    {
        static void Primo(int n)
        {
            int rest = 0;

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
        static void Main(string[] args)
        {
            int numero = 0;
            do
            {
                Console.WriteLine("Inserire il numero: ");
                numero = int.Parse(Console.ReadLine());
            } while (numero <= 0);

            Primo(numero);
        }
    }
}