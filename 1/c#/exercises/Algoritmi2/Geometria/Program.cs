//Es forme geometriche
using System;

namespace Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto2D prova = new Punto2D(5, 6);
            //richiamo l'oggetto prova e non la classe
            Console.WriteLine(prova.Distanza(5, 7));
            Console.ReadLine();            
        }

        public class Punto2D
        {
            public double x { get; private set; }
            public double y { get; private set; }

            public Punto2D(double X, double Y)
            {
                x = X;
                y = Y;
            }

            public double Distanza(double x2, double y2)
            {
                
                double variabile = Math.Pow(x2 - x, 2) + Math.Pow(y2 - y, 2);
                variabile = Math.Sqrt(variabile);
                return variabile;
            }

        }
    }
}
