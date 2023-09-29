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

namespace _1_AdivinaNumero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        public static int GenerarNum()
        {
            Random rn = new Random();
            int numeroAleatorio = rn.Next(0, 101);
            return numeroAleatorio;
        }
        public int numAleatorio = GenerarNum();
        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numAleatorio = GenerarNum();
            SolucionTextBlock.Text = "";
        }

        private void ComprarButton_Click(object sender, RoutedEventArgs e)
        {
            int Aleatorio = numAleatorio;
            int numeroIntroducido = int.Parse(nombreTextBox.Text);
            if(numeroIntroducido > Aleatorio)
            {
                SolucionTextBlock.Text = "Te has pasado";
            }
            if(numeroIntroducido < Aleatorio)
            {
                SolucionTextBlock.Text = "Te has quedado corto";
            }
            if(numeroIntroducido == Aleatorio)
            {
                SolucionTextBlock.Text = "Has acertado";
            }
        }
    }
}
