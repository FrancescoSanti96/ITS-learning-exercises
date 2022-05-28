using System;
using System.Collections;

namespace Cane_2
{
    class Program
    {
        public struct cane
        {
            public string razza, sesso, proprietario, microchip, anno;
        }

        static void Main(string[] args)
        {
            int n = 0;
            int d = 5;
            int num = 1;

            Console.WriteLine("Quanti cani devi inserire: ");
            n = int.Parse(Console.ReadLine());
            d = n * d;

            string[] canile = new string[d];
            cane cani = new cane();


            for (int i = 0; i < canile.Length; i++) //riempe l'array
            {
                Console.WriteLine("Inserimento cane: " + num);
                Console.WriteLine("");

                Console.WriteLine("Inserire la razza: ");
                cani.razza = Console.ReadLine();
                canile[i] = cani.razza;
                i++;

                Console.WriteLine("Inserire l'anno: ");
                cani.anno = Console.ReadLine();
                canile[i] = cani.anno;
                i++;

                Console.WriteLine("Inserire il sesso: ");
                cani.sesso = Console.ReadLine();
                canile[i] = cani.sesso;
                i++;

                Console.WriteLine("Inserire il proprietario: ");
                cani.proprietario = Console.ReadLine();
                canile[i] = cani.proprietario;
                i++;

                Console.WriteLine("Inserire il microchip: ");
                cani.microchip = (Console.ReadLine());
                canile[i] = cani.microchip;
                
                num++;
            }
            /*
            Console.WriteLine("I cani femmina sono i seguenti");
            Console.WriteLine("");
            for (int i = 0; i < canile.Length; i++)
            {
                if (canile[i] == "femmina")
                {
                    int lun = i + 2;
                    for (int e = i - 2; e <= lun; e++)
                    {
                        Console.WriteLine(canile[e]);
                    }

                }
                Console.WriteLine("");
            }

            Console.WriteLine("I cani maschio sono i seguenti");
            Console.WriteLine("");
            for (int i = 1; i < canile.Length; i++)
            {
                if (canile[i] == "maschio")
                {
                    int lun = i + 2;
                    for (int e = i - 2; e <= lun; e++)
                    {
                        Console.WriteLine(canile[e]);
                    }
                }
                Console.WriteLine("");
            }

            Console.WriteLine("I cani anziani sono i seguenti: ");
            Console.WriteLine("");
            for (int i = 1; i < canile.Length; i += 6)
            {
                int myInts = int.Parse(canile[i]);

                if (myInts > 10)
                {
                    int lun = i + 3;
                    for (int e = i - 1; e <= lun; e++)
                    {
                        Console.WriteLine(canile[e]);
                    }
                }
                Console.WriteLine("");
            }
            
            string prop = "";
            Console.WriteLine("Inserire il nome del proprietario: ");
            prop = Console.ReadLine();

            for (int i = 0; i < canile.Length; i++)
            {
                if (canile[i] == prop)
                {
                    int lun = i + 1;
                    for (int e = i - 3; e <= lun; e++)
                    {
                        Console.WriteLine(canile[e]);
                    }

                }
                Console.WriteLine("");
            }*/

            
            string temp;
            bool scambio;

            do
            {
                scambio = false; //resetto il flag
                for (int i = 1; i < canile.Length - 5; i += 5)
                {
                    int nt = int.Parse(canile[i]);
                    
                    int nt2 = int.Parse(canile[i + 5]);

                    if (nt > nt2)
                    {
                        int lun = i + 3;
                        for (int e = i - 1; e <= lun; e++)
                        {
                            temp = canile[e];
                            canile[e] = canile[e + 5];
                            canile[e + 5] = temp;
                            scambio = true;
                        }
                    }
                }
             } while (scambio) ;

                for (int i = 0; i < canile.Length; i++)
                {
                    Console.WriteLine(canile[i]);
                }
            
                
                Console.WriteLine("");
                Console.ReadLine();


    
        }    
    }
}


    

