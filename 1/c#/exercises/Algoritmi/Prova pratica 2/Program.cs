//Es 2 "Indovina il numero".

using System;

namespace Prova_pratica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ncasuale = 0, giocatore = 0, tentativi = 0;

            Random rnd = new Random((int)DateTime.Now.Ticks);
            ncasuale = rnd.Next(1,101);

            Console.WriteLine("Indovina il numero!!!");
            Console.WriteLine("");
            Console.WriteLine("Inserisci un numero e prova ad indovinare: ");

            do
            {
                giocatore = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (giocatore != ncasuale)
                {
                    if (giocatore > ncasuale)
                    {
                        Console.WriteLine("Attenzione il numero inserito è troppo grande, ritenta.");
                        Console.WriteLine("Reinserisci un numero e ritenta la fortuna: ");
                    }
                    else
                    {
                        Console.WriteLine("Attenzione il numero inserito è troppo piccolo, ritenta.");
                        Console.WriteLine("Reinserisci un numero e ritenta la fortuna: ");
                    }
                }

                tentativi += 1;

            } while (giocatore != ncasuale);

            Console.WriteLine("!!!Ottimo!!!, hai indovinato il numero: " + ncasuale + ". Con " + tentativi + " tentativi.");
            Console.ReadLine();
        }
    }
}
