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
using Week7Day3.Core;

namespace Week7Day3.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double a;
        private double b;
        private double c;
        private Equation equation = new Equation();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRisolvi_Click(object sender, RoutedEventArgs e)
        {
            a = double.Parse(valueA.Text);
            b = double.Parse(valueB.Text);
            c = double.Parse(valueC.Text);

            double[] risultati = equation.RisolviEquazioneSecondoGrado(a, b, c);

            if (risultati == null)
            {
                risultato.Text = "Equazione impossibile";
            }
            else if (risultati.Length == 1)
            {
                risultato.Text = "Risultato: x1 = x2 =" + risultati[0];
            }
            else if (risultati.Length == 2)
            {
                risultato.Text = "Risultati: x1 = " + risultati[0] + ", x2 = " + risultati[1];
            }
        }
    }
}
