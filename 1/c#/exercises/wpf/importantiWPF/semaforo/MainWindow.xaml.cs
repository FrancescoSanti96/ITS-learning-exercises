using System;
using System.Windows;
using System.Windows.Media;

namespace Semaforo
{
    public partial class MainWindow : Window
    {
        private DispositivoSemaforo sf;
        private DispositivoSemaforo.StatoSemaforo statoSemaforo;
        public MainWindow()
        {
            InitializeComponent();

            sf = new DispositivoSemaforo();
            sf.EventoCambioLuce += ModificaGrafica;
            sf.Start();            
        }

        private void CambiaColore()
        {
            if (statoSemaforo == DispositivoSemaforo.StatoSemaforo.Rosso)
            {
                elRed.Fill = new SolidColorBrush(Colors.Red);
                elYellow.Fill = new SolidColorBrush(Colors.Black);
                elGreen.Fill = new SolidColorBrush(Colors.Black);
            }
            else if (statoSemaforo == DispositivoSemaforo.StatoSemaforo.Giallo)
            {
                elRed.Fill = new SolidColorBrush(Colors.Black);
                elYellow.Fill = new SolidColorBrush(Colors.Yellow);
                elGreen.Fill = new SolidColorBrush(Colors.Black);
            }
            else
            {
                elRed.Fill = new SolidColorBrush(Colors.Black);
                elYellow.Fill = new SolidColorBrush(Colors.Black);
                elGreen.Fill = new SolidColorBrush(Colors.Green);
            }
        }

        private void ModificaGrafica(DispositivoSemaforo.StatoSemaforo stato)
        {
            statoSemaforo = stato;
            Dispatcher.Invoke(CambiaColore); //richiama il cambio di grafica.
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            sf.Spegni();
        }
    }
}
