using System;
using System.Windows;


namespace _2._1.AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int numGenerado = GenerarNumero();
        }
        private int GenerarNumero()
        {
            int numMax = 100;
            Random rd = new Random();
            
            return rd.Next(numMax);
        }

        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {
            int numAComprobar = int.Parse(NumeroIntroducido.Text);

            if (numAComprobar > numGenerado)
            {
                TextoComprobacion.Text = "Te has pasado";
            }
            else if (numAComprobar < numGenerado)
            {
                TextoComprobacion.Text = "Te has quedado corto";
            }
            else
            {
                TextoComprobacion.Text = "¡¡¡Has acertado!!!";
            }

        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
        }
        
    }
}
