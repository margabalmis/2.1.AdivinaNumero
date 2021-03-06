using System;
using System.Windows;


namespace _2._1.AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numGenerado;
        public MainWindow()
        {
            InitializeComponent();
            numGenerado = GenerarNumero();
        }
        private int GenerarNumero()
        {
            int numMax = 100;
            Random rd = new Random();
            
            return rd.Next(numMax);
        }

        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {
            int numAComprobar = int.Parse(numeroIntroducido.Text);

            if (numAComprobar > numGenerado)
            {
                textoComprobacion.Text = "Te has pasado";
            }
            else if (numAComprobar < numGenerado)
            {
                textoComprobacion.Text = "Te has quedado corto";
            }
            else
            {
                textoComprobacion.Text = "¡¡¡Has acertado!!!";
            }

        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numGenerado = GenerarNumero();
            numeroIntroducido.Clear();
            textoComprobacion.Text = string.Empty;
        }
        
    }
}
