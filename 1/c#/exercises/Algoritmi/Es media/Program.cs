//Calcola la media dei numeri inseriti

using System;

namespace Es_media
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeri, valore, somma = 0;
            double media;
            
            Console.WriteLine("Quanti valori vuoi inserire?");
            numeri = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Inserire i numeri.");

            for (int i = 0; i < numeri; i++)
            {
                valore = int.Parse(Console.ReadLine());
                somma = somma + valore; // oppure somma + = valore
            }

            media = somma / (double)numeri;

            Console.WriteLine("La media dei valori è " + media);

            Console.Read();
        }
    }
}
