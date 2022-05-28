//Fornita una frase in input, eliminare le vocali e stampare la frase risultante

using System;

namespace Stringhe_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int lun = 0;
            string frase, frasesv = "";
            do
            {
                Console.WriteLine("Inserisci una frase: ");
                frase = Console.ReadLine();
                lun = frase.Length;
            } while ((lun < 1) || (lun > 50));

            for (int i = 0; i < lun; i++)
            {
                if (frase[i] != 'a' && frase[i] != 'e' && frase[i] != 'i' && frase[i] != 'o' && frase[i] != 'u' &&
                    frase[i] != 'A' && frase[i] != 'E' && frase[i] != 'I' && frase[i] != 'O' && frase[i] != 'U')
                {
                    frasesv += frase[i];
                }
            }

            Console.WriteLine("La frase senza vocali è : " + frasesv);
            
            Console.WriteLine("");
            Console.ReadLine();

        }
    }
}
