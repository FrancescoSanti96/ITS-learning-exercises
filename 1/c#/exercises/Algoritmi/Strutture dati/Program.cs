//ES1
/*Caricato un array con 10 numeri casuali interi compresi tra 0 e 100,
chiedere in input il numero da cercare e dire se il numero è stato trovato
oppure no. In caso fosse stato trovato, rispondere anche con la posizione
della prima occorrenza.*/

using System;

namespace Strutture_dati
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = 0, R=0;
            int[] NUMERI;
            Random rnd = new Random((int)DateTime.Now.Ticks);
            bool trovato = false;

            do
            {
                Console.WriteLine("Inserire la lunghezza del vettore: ");
                N = int.Parse(Console.ReadLine());
            } while (N <= 0);

            Console.WriteLine("");

            NUMERI = new int[N];
            Console.WriteLine("");

            for (int i = 0; i < NUMERI.Length; i++) //stampa l'array a video 
            {
                NUMERI[i] = rnd.Next(101);
                Console.Write(NUMERI[i] + " ");
            }

            Console.WriteLine("");
            Console.ReadLine();

            do
            {
                Console.WriteLine("Inserire il numero da cercare: ");
                R = int.Parse(Console.ReadLine());
            } while (R <= 0);
           
            for (int i = 0; i < NUMERI.Length; i++)
            {
                if (NUMERI[i] == R)
                {
                    trovato = true;
                    break; // uscita immediata dal ciclo.
                }
            }
            if (trovato)
                Console.WriteLine("Trovato!!!");
            else
                Console.WriteLine("Non trovato.");

        }
    }
}
