﻿using System;
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
    /// Lógica de interacción para Salida.xaml
    /// </summary>
    public partial class Salida : Window
    {
        public Salida()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {


                MessageBox.Show("Salida Guardado Correctamente");

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
