using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculosPG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void CalcularPG()
        {
            /*
             * Fórmula:
             * 
             * Sn = a*(q^n - 1)/(q-1),
             * onde a = termo inicial, q = razão, n = nº de termos
             */
            double sn = 0;
            double a = 0;
            double q = 0;
            int n = 0;
            bool valido = true;
            //System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator
            // ou
            //System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
            if (!double.TryParse(txtPrimeiroTermo.Text, out a))
            {
                valido = false;
            }
            if (!double.TryParse(txtRazao.Text, out q))
            {
                valido = false;
            }
            if (!int.TryParse(txtQuantidadeTermos.Text, out n))
            {
                valido = false;
            }
            if (valido)
            {
                sn = a * ((Math.Pow(q, n) - 1) / (q - 1));
                txtResultado.Text = sn.ToString();
            }
            else
            {
                MessageBox.Show("Dados inválidos!");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularPG();
        }

        private void PressionarEnter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                CalcularPG();
            }
        }
    }
}
