
using System;
using System.Collections;

namespace Cane_1
{
    class Program
    {
        public struct Cane
        {
            public string razza, anno, sesso, proprietario, microchip;
            
        }
        static void Main(string[] args)
        {
            int numero = 0;
            ArrayList animali = new ArrayList();

            Console.WriteLine("Inserisci il numero di cani da inserire: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                Cane cani = new Cane();

                Console.WriteLine("Inserire la razza: ");
                cani.razza = Console.ReadLine();
                animali.Add(cani.razza);

                Console.WriteLine("Inserire l'anno: ");
                cani.anno = Console.ReadLine();
                animali.Add(cani.anno);

                Console.WriteLine("Inserire il sesso: ");
                cani.sesso = Console.ReadLine();
                animali.Add(cani.sesso);

                Console.WriteLine("Inserire il proprietario: ");
                cani.proprietario = Console.ReadLine();
                animali.Add(cani.proprietario);

                Console.WriteLine("Inserire il microchip: ");
                cani.microchip = (Console.ReadLine());
                animali.Add(cani.microchip);
            }

            int count = animali.Count;
            /* foreach (string b in animali)
                        {
                            if (b == "femmina")
                            {
                                Console.WriteLine("funziona");
                            }
                        }*/

            //Stampare i cani maschi
            //Console.WriteLine(animali[2]);
            //Console.WriteLine("");

            for (int i = 0; i < count; i++) //stampa l'array a video 
            {
                string femmina = "femmina";

                if (animali.Contains("StringToBeChecked")
                {
                    Console.WriteLine("Funziona");
                }
                else
                {
                    Console.WriteLine("nonFunziona");
                }
               
            }
            
            //Console.WriteLine("i dati inseriti: ");

 


            /*
            for (int i = 0; i < count; i++) //stampa l'array a video 
            {
                Console.Write(animali[i] + " ");
            }

            Console.WriteLine("");
            Console.ReadLine();*/



           /* Console.WriteLine("");
            Console.WriteLine("dati inseriti: ");
            Console.WriteLine(prova.razza);
            Console.WriteLine(prova.anno);
            Console.WriteLine(prova.sesso);
            Console.WriteLine(prova.proprietario);
            Console.WriteLine(prova.microchip);
            Console.ReadLine();*/
        
        }
    }
}
