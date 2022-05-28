using System;

namespace Es_Array_e_Matrici
{
    class Program
    {
        static void Main(string[] args)
        {

            //Esercizio 1

            int N = 0, P = 0;
            int[] NUMERI;

            do
            {
                Console.WriteLine("Inserire la lunghezza del vettore: ");
                N = int.Parse(Console.ReadLine());
            } while (N <= 0);

            Console.WriteLine("");

            do
            {
                Console.WriteLine("Inserire il numero da cui iniziare il riempimento del vettore: ");
                P = int.Parse(Console.ReadLine());
            } while (P <= 0);

            NUMERI = new int[N];
            Console.WriteLine("");

            if (P % 2 != 0)
            {
                P += 1;
            }

            for (int i = 0; i < NUMERI.Length; i++) //riempe l'array
            {
                NUMERI[i] = P;
                P += 2;
            }
   
            for (int i = 0; i < NUMERI.Length; i++) //stampa l'array a video 
            {
                Console.Write(NUMERI[i] + " ");
            }

            Console.WriteLine("");
            Console.ReadLine();
            


            //Esercizio 2

            int somma = 0, media = 0, count = 0;

            //Media
            for (int i = 0; i < NUMERI.Length; i++)
            {
                somma = somma + NUMERI[i];
            }

            media = somma / N;
            Console.WriteLine("La media dei valori è: " + media);
            Console.ReadLine();

            // Valore massimo e posizione
            count = (N - 1);
            Console.WriteLine("Il valore massimo è: " + NUMERI[N - 1] + " in posizione: " + count);
            Console.ReadLine();

            // Valore minimo e posizione
            Console.WriteLine("Il valore minimo è: " + NUMERI[0] + " in posizione: 0");
            Console.ReadLine();



            //Esercizio 3

            int[] NUMERI_INVERSI;
            NUMERI_INVERSI = new int[N];
            count = 0;
            Console.WriteLine("Numeri inversi: ");

            for (int i = NUMERI.Length -1; i >= 0; i--) 
            {
                NUMERI_INVERSI[count] = NUMERI[i];
                Console.Write(NUMERI_INVERSI[count] + " ");
                count += 1; 
            }

            Console.WriteLine("");
            Console.ReadLine();
            


            //Esercizio 4

            int[] NUMERI_DISPARI;
            NUMERI_DISPARI = new int[N];
            Console.WriteLine("Numeri dispari: ");

            for (int i = 0; i < NUMERI.Length; i++)
            {
                NUMERI_DISPARI[i] = (NUMERI[i] + 1);
                Console.Write(NUMERI_DISPARI[i] + " ");
            }

            Console.WriteLine("");
            Console.ReadLine();



            //Esercizio 5

            int[] NUMERI2;
            NUMERI2 = new int[N];
            Console.WriteLine("Numeri moltiplicati x 2: ");

            for (int i = 0; i < NUMERI.Length; i++)
            {
                NUMERI2[i] = (NUMERI[i] * 2);
                Console.Write(NUMERI2[i] + " ");
            }

            Console.WriteLine("");
            Console.ReadLine();



            //Esercizio 6

            int[ , ] M;
            int D = 0, C = 0;
            Random rnd = new Random((int)DateTime.Now.Ticks);
            
            do
            {
                Console.WriteLine("Inserire la grandezza della matrice M: ");
                D = int.Parse(Console.ReadLine());
            } while (D <= 0);

            M = new int[D,D];
            Console.WriteLine("");

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    C = rnd.Next(51);
                    M[i,j] = C;
                    Console.Write(M[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();



            //Esercizio 7

            int sommam = 0;

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    sommam = sommam + M[i,j];
                }
            }

            Console.WriteLine("La somma è: " + sommam);
            Console.ReadLine();



            //Esercizio 8

            int min = M[0,0];
            int countR = 0, countC = 0;

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (M[i,j] < min)
                    {
                        min = M[i,j];
                        countR = i;
                        countC = j;
                    }
                }
            }
        
            Console.WriteLine("Il valore minimo è: " + min + " in posizione Riga: " + countR + " Colonna: " + countC);
            Console.ReadLine();



            //Esercizio 9

            int[ , ] M2;
            M2 = new int[D,D];

            for (int i = 0; i < M2.GetLength(0); i++)
            {
                for (int j = 0; j < M2.GetLength(1); j++)
                {
                        M2[i,j] = M[j,i];
                        Console.Write(M2[i,j] + " ");
                }
                Console.WriteLine("");
            }

            Console.ReadLine();



            //Esercizio 10

            int D2 = 0;
            int[ , ] I;
           
            do
            {
                Console.WriteLine("Inserire la grandezza della matrice I: ");
                D2 = int.Parse(Console.ReadLine());
            } while (D2 <= 0);

            I = new int[D2,D2];
            Console.WriteLine("");

            for (int i = 0; i < I.GetLength(0); i++)
            {
                for (int j = 0; j < I.GetLength(1); j++)
                {
                    if ( i == j)
                    {
                        I[i,j] = 1;
                    }
                    else
                    {
                        I[i,j] = 0;
                    }

                    Console.Write(I[i, j] + " ");
                }
                Console.WriteLine("");
            }

            Console.ReadLine();

        }
    }
}
