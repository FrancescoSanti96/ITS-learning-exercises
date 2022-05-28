using System;

namespace RiempiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int len, n;
            int[] numeri;
            Random rnd = new Random((int)DateTime.Now.Ticks);

            Console.WriteLine("Quanti numeri vuoi?");
            len = int.Parse(Console.ReadLine());

            numeri = new int[len];

            //riempio l'array di numeri casuali
            for (int i = 0; i < numeri.Length; i++) //!leggere tutto l'array dall'inizio alla fine.!
            {
                n = rnd.Next(51);
                numeri[i] = n;
            }

            //stampo l'array a video    
            for (int i = 0; i < numeri.Length; i++)
            {
                Console.Write(numeri[i] + " ");
            }

            Console.Read();
        }
    }
}
