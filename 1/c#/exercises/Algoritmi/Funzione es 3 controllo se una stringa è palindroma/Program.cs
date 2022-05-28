using System;

namespace Funzione_es_3_controllo_se_una_stringa_è_palindroma
{
    class Program
    {
        static void palindroma(string parola)
        {
            int lun = parola.Length;
            string parolainversa = "";
            for (int i = lun - 1; i >= 0; i--)
            {
                parolainversa += parola[i];
            }

            if (parola == parolainversa)
            {
                Console.WriteLine("La parola è palidroma");
            }

            else
            {
                Console.WriteLine("La frase non è palindroma");
            }

        }
        static void Main(string[] args)
        {
            string parole = "";
            Console.WriteLine("Inserisci una parola: ");
            parole = Console.ReadLine();

            palindroma(parole);
        }
    }
}
