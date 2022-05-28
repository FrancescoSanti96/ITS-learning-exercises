using System;

namespace Funzioni_es_4_stampa_matrice
{
    class Program
    {
        static void PrintMatrice(int[,] M)
        {
            
            int C = 0;
            Random rnd = new Random((int)DateTime.Now.Ticks);



            Console.WriteLine("");

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    C = rnd.Next(51);
                    M[i, j] = C;
                    Console.Write(M[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            int D = 0;
            int[ , ] MI;

            do
            {
                Console.WriteLine("Inserire la grandezza della matrice M: ");
                D = int.Parse(Console.ReadLine());
            } while (D <= 0);

            MI = new int[D, D];

            PrintMatrice(MI);
        }
    }
}
