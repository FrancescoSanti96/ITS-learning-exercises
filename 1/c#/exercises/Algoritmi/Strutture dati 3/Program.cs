//ES 3
/*Caricato un array con 10 numeri casuali interi compresi tra 0 e 100,
applicare l'algoritmo di ordinamento bubble sort. Poi chiedere in input il
numero da cercare e, sull'array così ordinato, effettuare la ricerca del
valore fornito in input usando l'algoritmo di ricerca binaria.*/

using System;

namespace Strutture_dati_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int R = 0;
            int[] NUMERI;
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int temp;
            bool scambio;

            Console.WriteLine("");

            NUMERI = new int[10];
            Console.WriteLine("");

            for (int i = 0; i < NUMERI.Length; i++) 
            {
                NUMERI[i] = rnd.Next(101);
                Console.Write(NUMERI[i] + " ");
            }

            Console.WriteLine("");
            Console.ReadLine();

            do
            {
                scambio = false; //resetto il flag
                for (int i = 0; i < (NUMERI.Length - 1); i++)
                    if (NUMERI[i] > NUMERI[i + 1])
                    {
                        temp = NUMERI[i];
                        NUMERI[i] = NUMERI[i + 1];
                        NUMERI[i + 1] = temp;
                        scambio = true;
                    }
            } while (scambio);

            for (int i = 0; i < NUMERI.Length; i++)
            {
                Console.Write(NUMERI[i] + " ");
            }

            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
