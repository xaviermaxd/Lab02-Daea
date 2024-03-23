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
    /// Lógica de interacción para Reporte.xaml
    /// </summary>
    public partial class Reporte : Window
    {

        public List<Vehiculo> Vehiculos { get; set; }

        public Reporte()
        {
            InitializeComponent();

            Vehiculos = new List<Vehiculo>
            {
                new Vehiculo { PesoMaximo = 50, Placa = "123456", PesoVacio = 20 },
                new Vehiculo { PesoMaximo = 30, Placa = "456789", PesoVacio = 10 },
                new Vehiculo { PesoMaximo = 100, Placa = "858585", PesoVacio = 50 }
            };

            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListaVehiculos.ItemsSource = Vehiculos;
        }
    }

    public class Vehiculo
    {
        public int PesoMaximo { get; set; }
        public string Placa { get; set; }
        public int PesoVacio { get; set; }
    }


}
