/*Chiedere in input una frase e un numero intero, cifrare la frase utilizzando il
cifrario di Cesare e stampare la frase risultante*/
using System;

namespace Stringhe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lun = 0, n=0;
            string parola, cifrato = "", decifrato = "";
            
            do
            {
                Console.WriteLine("Inserisci una parola: ");
                parola = Console.ReadLine();
                lun = parola.Length;
            } while ((lun < 1) || (lun > 100));

            do
            {
                Console.WriteLine("Inserisci un numero: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);

            foreach (char c in parola)
            {
                int code = c;
                int code2 = 0;
                code2 = code + n;
                cifrato += (char)code2;
            }

            Console.WriteLine("Il messaggio inizilae era: ");
            Console.WriteLine(parola);
            Console.WriteLine("");
            Console.WriteLine("Il messaggio cifrato è: ");
            Console.WriteLine(cifrato);
            Console.WriteLine("");

            /*Chiedere in input la frase cifrata con il cifrario di Cesare e la chiave, stampare
            la frase decifrata*/

            foreach (char c in cifrato)
            {
                int code = c;
                int code2 = 0;
                code2 = code - n;
                decifrato += (char)code2;
            }

            Console.WriteLine("Il messaggio decifrato è: ");
            Console.WriteLine(decifrato);
            Console.ReadLine();
        }
    }
}
