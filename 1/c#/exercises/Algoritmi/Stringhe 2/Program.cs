/*Es 2 slide 8 Fornita una frase in input, contare quante vocali e quante consonanti ci sono.
(N.B.la frase può contenere lettere maiuscole o minuscole e anche simboli
come le virgole e i punti)*/

using System;

namespace stringhe.es2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci una frase: ");
            string frase = Console.ReadLine();

            Console.WriteLine("Bravo! Hai inserito una frase lunga {0} caratteri.", frase.Length);

            int vocali = 0, consonanti = 0;

            foreach (char c in frase)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                    c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    // è una vocale!!!!
                    vocali++;
                }
                else if ((c >= 'A' && c <= 'Z') ||
                    (c >= 'a' && c <= 'z'))
                {
                    consonanti++;
                }
            }

            Console.WriteLine("Nella frase ci sono {0} vocali e {1} consonanti.", vocali, consonanti);
            Console.ReadLine();
        }
    }
}