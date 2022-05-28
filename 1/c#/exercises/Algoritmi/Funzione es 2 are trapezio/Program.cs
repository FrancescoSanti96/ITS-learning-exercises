using System;

namespace Funzione_es_2_are_trapezio
{
    class Program
    {
        static double CalculateTrapArea(double bmg, double bmn, double h)
        {
            double area = ((bmg + bmn) * h) / 2;
            Console.WriteLine(area);
            return area;
        }
        static void Main(string[] args)
        {
            double a = 5, b = 8, h = 3;
            CalculateTrapArea(a,b,h);
        }
    }
}
