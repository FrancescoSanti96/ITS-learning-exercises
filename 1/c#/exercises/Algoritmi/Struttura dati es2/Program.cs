//ES 2
/*Caricato un array con 30 numeri casuali interi compresi tra 0 e 100,
chiedere in input il numero da cercare e dire quante volte il numero è
contenuto nell'array.*/

using System;

namespace Struttura_dati_es2
{
    class Program
    {
        static void Main(string[] args)
        {

            int R = 0, trovato = 0;
            int[] NUMERI;
            Random rnd = new Random((int)DateTime.Now.Ticks);

            NUMERI = new int[30];
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
                Console.WriteLine("Inserire il numero da cercare: ");
                R = int.Parse(Console.ReadLine());
            } while (R <= 0);

            for (int i = 0; i < NUMERI.Length; i++)
            {
                if (NUMERI[i] == R)
                {
                    trovato += 1;
                }
            }
            if (trovato > 0)
                Console.WriteLine("Trovato: " + trovato +" volte. ");
            else
                Console.WriteLine("Non trovato.");
        }
    }
}
