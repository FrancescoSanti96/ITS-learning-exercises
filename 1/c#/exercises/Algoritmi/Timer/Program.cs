using System;
using System.Timers;

namespace Timer
{
    class Program
    {
        private static System.Timers.Timer aTimer;

        static void Main(string[] args)
        {
            SetTimer(); // Avvia il timer
            Console.WriteLine("\nPress the Enter key to exit the application...\n");
            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            Console.ReadLine();

            aTimer.Stop();// ferma il timer
            aTimer.Dispose(); // chiude correttamente il timer
            Console.WriteLine("Terminating the application...");
        }

        ///<summary>
        ///Configura il timer e lo avvia.
        ///</summary>
        
        static void SetTimer()
        {
            //Create a tuner with a two second interval
            aTimer = new System.Timers.Timer(2000);
            //Hook up the Elapsed event for the timer.
            aTimer.Elapsed += OnTimeEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        ///<summary>
        ///Gestore dell'evento
        ///</summary>
        ///<param name="source">chi ha emesso <list type="'evento (il timer)"</param>
        ///<param name="e">dati dell'evento (es. il tempo in cui è scattato il timer)</param>
        
        static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("")
        }
}
