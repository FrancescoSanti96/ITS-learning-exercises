using System;
using System.Collections.Generic;

namespace gestioneFilmVersione1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Film> lista = new List<Film>();

            //Film

            Console.WriteLine("Quanti film voui aggiungere: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("Inserisci il titolo del film: ");
                string titolo = Console.ReadLine();

                Console.WriteLine("Inserisci il genere: ");
                string genere = Console.ReadLine();

                Console.WriteLine("Inserisci l'anno di pubblicazione");
                int anno = int.Parse(Console.ReadLine());

                Film catalogo = new Film(titolo, genere, anno);

                catalogo.informazioni();

                lista.Add(catalogo);
            }
 
            //Attori

            Console.WriteLine("Quanti attori voui aggiungere: ");
            int numero2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero2; i++)
            {

                Console.WriteLine("Inserisci il nome dell'attore: ");
                string titolo = Console.ReadLine();

                Console.WriteLine("Inserisci il cognome dell'attore: ");
                string genere = Console.ReadLine();

                Console.WriteLine("Inserisci il film in cui ha partecipato: ");
                string ricerca = Console.ReadLine();

                for (int e = 0; i < numero; i++)
                {
                    if(ricerca == lista[e].titolo)
                    {
                        //collegamento
                    }
                }

            }


          Console.WriteLine(lista[0]);
            Console.ReadLine();
        }

        public class Film // inserimento
        {
            public string titolo { get; private set; }
            public string genere { get; private set; }
            public int anno { get; private set; }
        
            public Film(string Titolo, string Genere, int Anno)
            {
                titolo = Titolo;
                genere = Genere;
                anno = Anno;
            }

            public void informazioni()
            {
                Console.WriteLine("Informazioni film inserito: {0}  {1}  {2}." , titolo , genere , anno);   
            }
        }

        public class Attori
        {
            public string nome { get; private set; }
            public string cognome { get; private set; }
            public Film film { get; private set; }

            public Attori(string Nome, string Cognome, Film Film)
            {
                nome = Nome;
                cognome = Cognome;
                film = Film;
            }
        }




    }
}
