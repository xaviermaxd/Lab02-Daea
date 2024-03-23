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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Salida_Click(object sender, RoutedEventArgs e)
        {
            Salida salida = new Salida();
            salida.Show();
            this.Close();
        }


        private void Camiones_Click(object sender, RoutedEventArgs e)
        {
            Camion camion = new Camion();
            camion.Show();
            this.Close();
        }

        private void Reporte_Click(object sender, RoutedEventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Show();
            this.Close();
        }

    }
}
