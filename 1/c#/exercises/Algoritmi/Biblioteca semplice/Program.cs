//Biblioteca semplice
using System;

namespace Biblioteca_semplice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int d = 3;
            int num = 1;

            Console.WriteLine("Quanti Libri devi inserire: ");
            n = int.Parse(Console.ReadLine());
            d = n * d;

            string[] Arraylibri = new string[d];
            Libro slibro = new Libro();


            for (int i = 0; i < Arraylibri.Length; i++) //riempe l'array
            {
                Console.WriteLine("Inserimento Libro numero: " + num);
                Console.WriteLine("");

                Console.WriteLine("Inserire il titolo: ");
                slibro.Titolo = Console.ReadLine();
                Arraylibri[i] = slibro.Titolo;
                i++;

                Console.WriteLine("Inserire l'autore: ");
                slibro.Autore = Console.ReadLine();
                Arraylibri[i] = slibro.Autore;
                i++;

                Console.WriteLine("Inserire l'editore: ");
                slibro.Editore = Console.ReadLine();
                Arraylibri[i] = slibro.Editore;

                Console.WriteLine("Inserire il numero di copie: ");
                slibro.NumeroDisponibili = Console.ReadLine();
                Arraylibri[i] = slibro.NumeroDisponibili;

                num++;
            }

            //Tesserati

            //Prestiti

            /*Console.WriteLine("I libri inseriti sono i seguenti: ");
            Console.WriteLine("");
            for (int i = 0; i < Arraylibri.Length; i++)
            {
                Console.WriteLine(Arraylibri[i]);
                Console.WriteLine("");
            }
            Console.WriteLine(Arraylibri[3]);*/

            Console.ReadLine();
        }
        public struct Libro
        {
            /* public Libro(string titolo, string editore, string autore)
             {
                 Titolo = titolo;
                 Editore = editore;
                 Autore = autore;
             }*/

            public string Titolo;
            public string Editore;
            public string Autore;
            public string NumeroDisponibili;
            public string NumeroPrestate;


        }
        public struct prestito
        {
            public Libro libro;
            public tesserato tesserato;
        }

        public struct tesserato
        {
            public string Nome;
            public prestito prestito;
        }


    }
}
