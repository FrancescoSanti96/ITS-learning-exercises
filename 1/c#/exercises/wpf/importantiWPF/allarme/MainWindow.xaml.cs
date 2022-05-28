using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sveglia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Timer timer;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnImposta_Click(object sender, RoutedEventArgs e)
        {
            string orario = txtOrario.Text; // 12:00
            DateTime oggi = DateTime.Now.Date; // 29/01/2021 00:00:00
            TimeSpan orarioAlarm;
            if(!TimeSpan.TryParse(orario, out orarioAlarm))
            {
                MessageBox.Show("Inserisci un formato corretto.");
                return;
            }
            DateTime dtAlarm = oggi + orarioAlarm;

            TimeSpan delta = dtAlarm - DateTime.Now;

            if(delta < TimeSpan.Zero)
            {
                // la sveglia è per domani!
                dtAlarm = dtAlarm.AddDays(1);
                delta = dtAlarm - DateTime.Now;
            }

            timer = new Timer(delta.TotalMilliseconds);
            timer.Elapsed += SuonaLaSveglia;
            timer.Enabled = true;

            MessageBox.Show("Sveglia impostata per le " + dtAlarm.ToString());
        }

        private void SuonaLaSveglia(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            timer.Dispose();

            MessageBox.Show("Sveglia!!!!!!");            
        }
    }
}
