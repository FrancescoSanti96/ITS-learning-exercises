//Biblioteca
using System;
using System.Collections;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Biblioteca
{
    class Program
    {

        static void Main(string[] args)
        {
            string n = "";
            string titolo = "";
            string editore = "";
            string autore = "";
            
            //ArrayList libric = new ArrayList();

                
            Console.WriteLine("Vuoi inserie un nuovo libro: ");
            n = Console.ReadLine();
            Console.WriteLine(" ");

            if (n == "si")
            {
                Console.WriteLine("Inserire il titolo: ");
                titolo = Console.ReadLine();
                Console.WriteLine(" ");

                Console.WriteLine("Inserire l'editore: ");
                editore = Console.ReadLine();
                Console.WriteLine(" ");

                Console.WriteLine("Inserire l'autore: ");
                autore = Console.ReadLine();
                Console.WriteLine(" ");


                Libro p1 = new Libro(titolo,editore,autore);

                //string json = JsonSerializer.Serialize(p1);
                //File.WriteAllText("libreria.json", json);
            }
            
        }
        public struct Libro
        {
            public Libro(string titolo, string editore, string autore)
            {
                Titolo = titolo;
                Editore = editore;
                Autore = autore;
            }

            public string Titolo { get; }
            public string Editore { get; }
            public string Autore { get; }

        }

    }
}








