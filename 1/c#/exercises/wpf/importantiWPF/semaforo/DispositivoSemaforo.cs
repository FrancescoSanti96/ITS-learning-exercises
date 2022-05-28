using System.Timers;

namespace Semaforo
{
    public class DispositivoSemaforo
    {
        private Timer t;
        private StatoSemaforo stato;

        public delegate void CambioLuce(StatoSemaforo stato);

        public event CambioLuce EventoCambioLuce;

        public DispositivoSemaforo()
        {
            stato = StatoSemaforo.Giallo;
        }

        public void Start()
        {
            CambioStato(null, null);

            t = new Timer(5000);
            t.Elapsed += CambioStato;
            t.Enabled = true;
            t.AutoReset = true;
        }

        public void Spegni()
        {
            t.Stop();
            t.Dispose();
        }

        private void CambioStato(object sender, ElapsedEventArgs e)
        {
            switch (stato)
            {
                case StatoSemaforo.Rosso:
                    stato = StatoSemaforo.Verde;
                    break;
                case StatoSemaforo.Giallo:
                    stato = StatoSemaforo.Rosso;
                    break;
                case StatoSemaforo.Verde:
                    stato = StatoSemaforo.Giallo;
                    break;
                default:
                    stato = StatoSemaforo.Rosso;
                    break;
            }

            // Debug.WriteLine(stato);

            if (EventoCambioLuce != null)
                EventoCambioLuce(stato);
        }

        public enum StatoSemaforo
        {
            Rosso,
            Giallo,
            Verde
        }
    }
}
