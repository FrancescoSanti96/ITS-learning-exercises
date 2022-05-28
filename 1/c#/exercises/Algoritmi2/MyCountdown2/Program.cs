//Countdown 2
using System;

namespace MyCountdown2
{
    using System;
    using System.Timers;

    namespace Timer
    {
        class Program
        {
            static System.Timers.Timer aTimer;
            static DateTime impostazione;

            static void Main(string[] args)
            {
                Console.WriteLine("Imposta la svegli con data e ora: ");
                impostazione = DateTime.Parse(Console.ReadLine());
                SetTimer();

                Console.WriteLine("Per staccare la svelgia premi invio");
                Console.WriteLine("La data di sveglia è la seguente {0:HH:mm:ss.fff}", impostazione);
                Console.ReadLine();

                aTimer.Stop();
                aTimer.Dispose(); // chiude correttamente il timer
                Console.WriteLine("sveglia staccata");
            }

            static void SetTimer()
            {

                aTimer = new System.Timers.Timer(1000);
                aTimer.Elapsed += OnTimedEvent;
                aTimer.AutoReset = true;
                aTimer.Enabled = true;
            }

            static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
            {
                DateTime oggi = DateTime.Now;
                if (oggi < impostazione)
                {
                    TimeSpan diff = oggi.Subtract(impostazione);
                    Console.WriteLine("{0}", diff);
                }
                else
                {
                    Console.WriteLine("Aho sveglaiti");
                    SvegliaStop();
                }

            }

            static void SvegliaStop()
            {
                aTimer.Stop();
                aTimer.Dispose();
            }
        }
    }
}