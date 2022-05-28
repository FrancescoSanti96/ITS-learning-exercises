using System;

namespace Funzione_es_1
{
    class Program
    {
        static void PrintArray(int[] a)
        {
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] Ciao = new int[5] { 1, 2, 3, 5, 6 };
            PrintArray(Ciao);
        }
    }
}