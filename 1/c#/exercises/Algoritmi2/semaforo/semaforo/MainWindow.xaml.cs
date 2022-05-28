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

namespace semaforo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int currentImage;
        public MainWindow()
        {
            InitializeComponent();
            currentImage = 0;
        }

        private void MudaCor_Click(object sender, RoutedEventArgs e)
        {
            switch (currentImage)
            {
                case 0:
                    semaforo.Source = (BitmapImage) Application.Current.Resources["semaforoVermelho"];
                    break;
                case 1:
                    semaforo.Source = (BitmapImage) Application.Current.Resources["semaforoVerde"];
                    break;
                case 2:
                    semaforo.Source = (BitmapImage) Application.Current.Resources["semaforoAmarelo"];
                    break;
            }
            currentImage = (currentImage++ == 2) ? 0 : currentImage;
        }
    }
}
