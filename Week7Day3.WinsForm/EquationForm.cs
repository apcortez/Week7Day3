using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week7Day3.Core;

namespace Week7Day3.WinsForm
{
    public partial class EquationForm : Form
    {
        private double a;
        private double b;
        private double c;
        private Equation equation = new Equation();
        public EquationForm()
        {
            InitializeComponent();
        }

        private void buttonRisolvi_Click(object sender, EventArgs e)
        {
            a = double.Parse(valueA.Text);
            b = double.Parse(valueB.Text);
            c = double.Parse(valueC.Text);

            double[] risultati = equation.RisolviEquazioneSecondoGrado(a, b, c);

            if(risultati == null)
            {
                risultato.Text = "Equazione impossibile";
            }
            else if(risultati.Length == 1)
            {
                risultato.Text = "Risultato: x1 = x2 =" + risultati[0];
            }
            else if(risultati.Length == 2)
            {
                risultato.Text = "Risultati: x1 = " + risultati[0] + ", x2 = " + risultati[1];
            }
        }
    }
}
