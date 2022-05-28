using System;

namespace Persone
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer francesco = new Programmer("Francesco", "Santi", "Full Stack", "Google");
            Console.WriteLine("{0} {1} is a {2} and work and study in {3}.",
            francesco.Name, francesco.Cognome, francesco.Designation, francesco.CompanyName);
            Console.WriteLine(francesco.Learn());
            Console.WriteLine(francesco.Coding());
        }

        public class Person
        {
            public string Name { get; private set; }
            public string Cognome { get; private set; }

            public string Designation { get; private set; }
            protected Person(string name, string cognome, string designation)
            {
                Name = name;
                Cognome = cognome;
                Designation = designation;
            }
            public string Learn()
            {
                return "I'm learning.";
            }
            public string Walk()
            {
                return "I'm walking.";
            }
            public string Eat()
            {
                return "I'm eating.";
            }
        }

        public class Programmer : Person
        {
            public string CompanyName { get; private set; }
            public Programmer(string name, string cognome, string role, string companyName) : base(name, cognome, role)
            {
                CompanyName = companyName;
            }
            public string Coding()
            {
                return "!!!!!!!I'm coding C#!!!!!!!";
            }
        }
    }
}
