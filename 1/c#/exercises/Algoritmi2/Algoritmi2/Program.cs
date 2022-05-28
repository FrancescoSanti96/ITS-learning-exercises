//Es cani slide 8
using System;

namespace Algoritmi2
{
    class Program
    {
        struct cane 
        {
            public string nome;
            public string razza;
            public int anni;
            public string sesso;
            public string proprietario;
            public string chip;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Quanti cani vuoi inserire? ");
            int numeroCani = int.Parse(Console.ReadLine());
            
            //Creo un array con la forma della strct
            cane[] arrayCani = new cane[numeroCani];

            for (int i = 0; i < arrayCani.Length; i++)
            {
                cane caneInserito = new cane();

                Console.WriteLine("Inseire il nome: ");
                caneInserito.nome = Console.ReadLine();
                Console.WriteLine("Inseire la razza: ");
                caneInserito.razza = Console.ReadLine();
                Console.WriteLine("Inseire gli anni: ");
                caneInserito.anni = Console.ReadLine();
                Console.WriteLine("Inseire il sesso: ");
                caneInserito.sesso = Console.ReadLine();
                Console.WriteLine("Inseire il proprietario: ");
                caneInserito.proprietario = Console.ReadLine();
                Console.WriteLine("Inseire il chip: ");
                caneInserito.chip = Console.ReadLine();
                
                //Inserisco in ogni posizione dell'array i dati della struct
                arrayCani[i] = caneInserito;
            }
            //Le varie funzioni che richiamo per rendere il main compatto e semplice

            //  Femmine(arrayCani);
            //  Maschio(arrayCani);
            //  Anziani(arrayCani);
            //  Stampa(arrayCani);
            // string nproprietario = "";
            // Console.WriteLine("Cerca con il nome del proprietario: ");
            // nproprietario = Console.ReadLine();
            // Nome(arrayCani,nproprietario);
            //  Ordinare(arrayCani);

            Console.ReadLine();
        }
        static void Stampa(cane[] arrayCani)
        {
            for (int i = 0; i < arrayCani.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Nome cane: {0}", arrayCani[i].nome);
                Console.WriteLine("Razza cane: {0}", arrayCani[i].razza);
                Console.WriteLine("Anni cane: {0}", arrayCani[i].anni);
                Console.WriteLine("Sesso cane: {0}", arrayCani[i].sesso);
                Console.WriteLine("Proprietario cane: {0}", arrayCani[i].proprietario);
                Console.WriteLine("Chip cane: {0}", arrayCani[i].chip);
            }
        }

        static void Femmine(cane[] arrayCani)
        {
            for (int i = 0; i < arrayCani.Length; i++)
            {
                Console.WriteLine("I cani femmina sono i seguenti:");
                if (arrayCani[i].sesso == "femmina")
                {
                    Console.WriteLine();
                    Console.WriteLine("Nome cane: {0}", arrayCani[i].nome);
                    Console.WriteLine("Razza cane: {0}", arrayCani[i].razza);
                    Console.WriteLine("Anni cane: {0}", arrayCani[i].anni);
                    Console.WriteLine("Sesso cane: {0}", arrayCani[i].sesso);
                    Console.WriteLine("Proprietario cane: {0}", arrayCani[i].proprietario);
                    Console.WriteLine("Chip cane: {0}", arrayCani[i].chip);
                }
            }
        }

        static void Maschio(cane[] arrayCani)
        {
            for (int i = 0; i < arrayCani.Length; i++)
            {
                Console.WriteLine("I cani maschio sono i seguenti:");
                if (arrayCani[i].sesso == "maschio")
                {
                    Console.WriteLine();
                    Console.WriteLine("Nome cane: {0}", arrayCani[i].nome);
                    Console.WriteLine("Razza cane: {0}", arrayCani[i].razza);
                    Console.WriteLine("Anni cane: {0}", arrayCani[i].anni);
                    Console.WriteLine("Sesso cane: {0}", arrayCani[i].sesso);
                    Console.WriteLine("Proprietario cane: {0}", arrayCani[i].proprietario);
                    Console.WriteLine("Chip cane: {0}", arrayCani[i].chip);
                }
            }
        }

        static void Anziani(cane[] arrayCani)
        {
            for (int i = 0; i < arrayCani.Length; i++)
            {
                Console.WriteLine("I cani anziani sono i seguenti:");
                if (Int32.Parse(arrayCani[i].anni) > 10)
                {
                    Console.WriteLine();
                    Console.WriteLine("Nome cane: {0}", arrayCani[i].nome);
                    Console.WriteLine("Razza cane: {0}", arrayCani[i].razza);
                    Console.WriteLine("Anni cane: {0}", arrayCani[i].anni);
                    Console.WriteLine("Sesso cane: {0}", arrayCani[i].sesso);
                    Console.WriteLine("Proprietario cane: {0}", arrayCani[i].proprietario);
                    Console.WriteLine("Chip cane: {0}", arrayCani[i].chip);
                }
            }
        }

        static void Nome(cane[] arrayCani, string nome)
        {
            for (int i = 0; i < arrayCani.Length; i++)
            {
                if (arrayCani[i].proprietario == nome)
                {
                    Console.WriteLine();
                    Console.WriteLine("Nome cane: {0}", arrayCani[i].nome);
                    Console.WriteLine("Razza cane: {0}", arrayCani[i].razza);
                    Console.WriteLine("Anni cane: {0}", arrayCani[i].anni);
                    Console.WriteLine("Sesso cane: {0}", arrayCani[i].sesso);
                    Console.WriteLine("Proprietario cane: {0}", arrayCani[i].proprietario);
                    Console.WriteLine("Chip cane: {0}", arrayCani[i].chip);
                }
            }
        }

        static void Ordinare(cane[] arrayCani)
        {
            cane[] temp = new cane[arrayCani.Length];
            bool scambio;
            do
            {
                scambio = false; //resetto il flag
                for (int i = 0; i < (arrayCani.Length - 1); i++)
                    if (Int32.Parse(arrayCani[i].anni) > Int32.Parse(arrayCani[i + 1].anni))
                    {
                        temp[i] = arrayCani[i];
                        arrayCani[i] = arrayCani[i + 1];
                        arrayCani[i + 1] = temp[i];
                        scambio = true;
                    }
            } while (scambio);
        }
    }
}
