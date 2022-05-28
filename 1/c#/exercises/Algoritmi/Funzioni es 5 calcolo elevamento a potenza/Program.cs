using System;

namespace Funzioni_es_5_calcolo_elevamento_a_potenza
{
    class Program
    {
        static void potenza(int a, int b)
        {
            int potenza = a;
            for (int i = 1; i < b; i++)
            {
                potenza = potenza * a; 
            }
            Console.WriteLine(potenza);
            
        }
        static void Main(string[] args)
        {
            int a = 4, b = 8;
            potenza(a, b);
        }
    }
}
