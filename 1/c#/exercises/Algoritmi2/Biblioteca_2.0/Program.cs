//Biblioteca 2.0
using System;
using System.Collections;

namespace Biblioteca_2._0
{
    struct libri
    {
        public string titolo;
        public string autore;
        public string editore;
        //public int copieDisponibili;
        //public int copiePrestate;
    }

    struct tesserati
    {
        public string nome;
        public string cognome;
        public string codice;
    }

    struct prestiti
    {
        public libri prestato;
        public tesserati tesserato;
        public DateTime data;
        public DateTime scadenza;
    }

    class Program
    {
        static void Main(string[] args)
        {   //1. memorizzare libri, tesserati e prestiti
            //Libri:
            Console.WriteLine("Quanti sono il libri da inserire? ");
            int numeroLibri = int.Parse(Console.ReadLine());
            //
            //ArrayList(libri)  = new ArrayList
               // libri() arrayLibri = new libri(numeroLibri);
            //ArrayList(libri) arrayLibri = new Arraylist(libri);
            ArrayList arrayLibri = new ArrayList();
            for (int i = 0; i < numeroLibri; i++)
            {
                libri libroInserito = new libri();

                Console.WriteLine("Inseire il titolo: ");
                libroInserito.titolo = Console.ReadLine();
                Console.WriteLine("Inseire l'autore: ");
                libroInserito.autore = Console.ReadLine();
                Console.WriteLine("Inseire l'editore: ");
                libroInserito.editore = Console.ReadLine();
                //Console.WriteLine("Inseire le copie disponibili: ");
                //libroInserito.copieDisponibili = Int32.Parse(Console.ReadLine());
                //Console.WriteLine("Inseire le copie prestate: ");
                //libroInserito.copiePrestate = Int32.Parse(Console.ReadLine());

                //Inserisco in ogni posizione dell'array i dati della struct
                //arrayLibri[i] = libroInserito;
                arrayLibri.Add(libroInserito);
            }

            //Tesserati:
            Console.WriteLine("Quanti sono i tesserati da inserire? ");
            int numeroTesserati = int.Parse(Console.ReadLine());
            ArrayList arrayTesserati = new ArrayList();
            for (int i = 0; i < numeroTesserati; i++)
            {
                tesserati tesseratoInserito = new tesserati();

                Console.WriteLine("Inseire il nome: ");
                tesseratoInserito.nome = Console.ReadLine();
                Console.WriteLine("Inseire il cognome: ");
                tesseratoInserito.cognome = Console.ReadLine();
                Console.WriteLine("Inseire il codice: ");
                tesseratoInserito.codice = Console.ReadLine();

                arrayTesserati[i] = tesseratoInserito;
            }

            //Prestiti;
            Console.WriteLine("Quanti sono i prestiti da inserire? ");
            int numeroPrestiti = int.Parse(Console.ReadLine());
            ArrayList arrayPrestiti = new ArrayList();
            for (int i = 0; i < numeroPrestiti; i++)
            {
                prestiti presitoInserito = new prestiti();

                string rtitolo = "";
                Console.WriteLine("Inseire il titolo: ");
                rtitolo = Console.ReadLine();
                for (int e = 0; e < arrayLibri.Count; e++)
                {
                    if (arrayLibri[e].titolo == rtitolo)
                    {
                        presitoInserito.prestato = arrayLibri[e];
                        e = arrayLibri.Count;
                    }
                }

                string codTesserato = " ";
                Console.WriteLine("Inseire il codice tesserato: ");
                codTesserato = Console.ReadLine();
                for (int e = 0; e < arrayTesserati.Count; e++)
                {
                    if (arrayTesserati[e].codice == codTesserato)
                    {
                        presitoInserito.tesserato = arrayTesserati[e];
                        e = arrayTesserati.Count;
                    }
                }

                Console.WriteLine("Inseire la data: ");
                string s = Console.ReadLine();
                //"30/03/2019 15:56:11"
                DateTime date1 = DateTime.Parse(s);
                presitoInserito.data = date1;
                DateTime date2 = date1.AddDays(15);
                presitoInserito.scadenza = date2;

                arrayPrestiti[i] = presitoInserito;
            }

            //2. elencare i prestiti di un certo libro
            Console.WriteLine("Inseire il titolo per cercare i prestiti correlati: ");
            string ctitolo = Console.ReadLine();
            prestitiLibro(arrayPrestiti, ctitolo);

            //3. elencare i prestiti di un tesserato
            Console.WriteLine("Inseire il codice tesserato: ");
            string ccodice = Console.ReadLine();
            prestitoTesserato(arrayPrestiti, ccodice);

            //4. elencare i prestiti scaduti alla data attuale
            Console.WriteLine("I seguenti libri sono scaduti: ");
            prestitiScaduti(arrayPrestiti);
            Console.ReadLine();
        }
        /* static libri CercaLibro(libri[] arrayLibri,string titolo)
         {

             for (int i = 0; i < arrayLibri.Length; i++)
             {
                 if (arrayLibri[i].titolo == titolo)
                 {
                     //arrayLibri[i].copieDisponibili =- 1;
                     // arrayLibri[i].copiePrestate =+ 1;

                     return arrayLibri[i];
                 }
                 Console.WriteLine("il libro non è presente.");
             }
         }*/
        /* static void CercaTesserato(tesserati[] arrayTesserato, string codice)
         {
             for (int i = 0; i < arrayTesserato.Length; i++)
             {
                 if (arrayTesserato[i].codice == codice)
                 {
                     arrayTesserato[i].libri = 1;
                 }
             }
         }*/
        static void prestitiLibro(List<prestiti> arrayPrestiti, string titolo)
        {
            for (int i = 0; i < arrayPrestiti.Count; i++)
            {
                if (arrayPrestiti[i].prestato.titolo == titolo)
                {
                    Console.WriteLine("Il libro {0} è stato prestato a: {1}, {2}", titolo, arrayPrestiti[i].tesserato.nome, arrayPrestiti[i].tesserato.cognome);
                }
            }
        }
        static void prestitoTesserato(List<prestiti> arrayPrestiti, string codice)
        {
            for (int i = 0; i < arrayPrestiti.Count; i++)
            {
                if (arrayPrestiti[i].tesserato.codice == codice)
                {
                    Console.WriteLine(" {0} ", arrayPrestiti[i].prestato.titolo);
                }
            }
        }
        static void prestitiScaduti(List<prestiti> arrayPrestiti)
        {
            for (int i = 0; i < arrayPrestiti.Count; i++)
            {
                DateTime date3 = DateTime.Now;

                if (arrayPrestiti[i].scadenza < date3)
                {
                    Console.WriteLine("Il segente prestito è scaduto: {0} prestato ha {1}", arrayPrestiti[i].prestato.titolo, arrayPrestiti[i].tesserato.nome);
                }
            }
        }
    }
}
