using System;

namespace Geometria2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Triangolo traingolo1 = new Triangolo(5, 7, 8);
            Console.WriteLine("Area triangolo: {0} , perimetro: {1}.", traingolo1.Area(), traingolo1.Perimetro());
            Console.WriteLine(traingolo1.Tipologia());
            Console.WriteLine();

            Quadrato quadrato1 = new Quadrato(5);
            Console.WriteLine("Area quadrato: {0} , perimetro: {1}.", quadrato1.Area(), quadrato1.Perimetro());
            Console.WriteLine();

            Rettangolo rettangolo1 = new Rettangolo(5,7);
            Console.WriteLine("Area rettangolo: {0} , perimetro: {1}.", rettangolo1.Area(), rettangolo1.Perimetro());
            Console.WriteLine();

            Cerchio cerchio1 = new Cerchio(10);
            Console.WriteLine("Area cerchio: {0} , perimetro: {1}.", cerchio1.Area(), cerchio1.Perimetro());
            Console.WriteLine();

            Console.ReadLine();
        }

        public abstract class FigureGeometriche
        {
            public abstract double Area();
            public abstract double Perimetro();
        }

        public class Triangolo : FigureGeometriche
        {
            public int Lato1 { get; private set; }
            public int Lato2 { get; private set; }
            public int Lato3 { get; private set; }

            public Triangolo(int lato1, int lato2, int lato3)
            {
                Lato1 = lato1;
                Lato2 = lato2;
                Lato3 = lato3;
            }
            public override double Perimetro()
            {
                double perimetro = Lato1 + Lato2 + Lato3;
                return perimetro;
            }
            public override double Area()
            {
                double Sperimetro = (Lato1 + Lato2 + Lato3) / 2;
                double area = Math.Sqrt(Sperimetro * (Sperimetro - Lato1) * (Sperimetro - Lato2) * (Sperimetro - Lato3));
                return area;
            }

            //Manca di capire se è un triangolo rettangolo
            public string Tipologia()
            {
                string tipo = "";

                if (Lato1 == Lato2 &  Lato1 == Lato3)
                {
                    tipo = "equilatero";
                    return tipo;
                }

                else if (Lato1 == Lato2 | Lato1 == Lato3)
                {
                    tipo = "isoscele";
                    return tipo;
                }

                else
                {
                     tipo = "scaleno";
                     return tipo;
                }
            }
        }

            public class Quadrato : FigureGeometriche
            {
                public int Lato1 { get; private set; }

                public Quadrato(int lato1)
                {
                    Lato1 = lato1;
                }

            public override double Perimetro()
            {
                double perimetro = Lato1 * 4;
                return perimetro;
            }
            public override double Area()
                {
                    double area = Lato1 * Lato1;
                    return area;
                }
            }

        public class Rettangolo : FigureGeometriche
        {
            public int Lato1 { get; private set; }
            public int Lato2 { get; private set; }

            public Rettangolo(int lato1, int lato2)
            {
                Lato1 = lato1;
                Lato2 = lato2;
            }

            public override double Perimetro()
            {
                double perimetro = Lato1 * 2 + Lato2 * 2;
                return perimetro;
            }
            public override double Area()
            {
                double area = Lato1 * Lato2;
                return area;
            }
        }

        public class Cerchio : FigureGeometriche
        {
            public int Raggio { get; private set; }

            public Cerchio(int raggio)
            {
                Raggio = raggio;
            }

            public override double Perimetro()
            {
                double perimetro = 2 * Math.PI * Raggio;
                return perimetro;
            }
            public override double Area()
            {
                double area = area = Raggio * Raggio * Math.PI;
                return area;
            }
        }
    }
}

