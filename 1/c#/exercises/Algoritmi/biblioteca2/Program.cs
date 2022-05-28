using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace biblioteca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro p1 = new Libro("Francesco","c#");

            string json = JsonSerializer.Serialize(p1);
            File.WriteAllText("libreria.json", json);

            
        }
    }
    public struct Libro
    {
        public Libro(string x, string y)
        {
            Titolo = x;
            Autore = y;
        }

        public string Titolo { get; }
        public string Autore { get; }

       // public override string ToString() => $"({X}, {Y})";
    }
}
