using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
namespace WpfApp1
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum Veicolo
        {
            Auto,
            Moto
        }

        enum Genere
        {
            Maschio,
            Femmina
        }

        private List<Veicolo> veicoli;
        private List<Persona> persone;
        public MainWindow()
        {
            InitializeComponent();

            veicoli = new List<Veicolo>()
            {
                Veicolo.Auto,
                Veicolo.Moto
            };

            cmbVeicolo.ItemsSource = veicoli;
            cmbVeicolo.SelectedIndex = 0;

            persone = new List<Persona>();
            lstPersone.ItemsSource = persone;
        }

        struct Persona
        {
            public Persona(string nome, bool privato, Veicolo veicolo, Genere genere)
            {
                Nome = nome;
                Privato = privato;
                Veicolo = veicolo;
                Genere = genere;
            }

            public string Nome { get; set; }
            public bool Privato { get; set; }
            public Veicolo veicolo { get; set; }
            public Genere Genere { get; set; }

            public override string ToString()
            {
                return Nome;
            }
        }

        private void btnSalva_Click(object sender, RoutedEventArgs e)
        {
            string nome = txtNome.Text;
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Devi scrivere il nome.");
                return;
            }

            bool privato = (bool)cbPrivato.IsChecked;
            Veicolo veicolo = (Veicolo)cmbVeicolo.SelectedValue;
            Genere genere;
            if ((bool)rbM.IsChecked)
            {
                genere = Genere.Maschio;
            }
            else
            {
                genere = Genere.Femmina;
            }

            Persona p = new Persona(nome, privato, veicolo, genere);
            persone.Add(p);
            lstPersone.Items.Refresh();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void cmbVeicolo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
