using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Amortizacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<double> amortiz = new List<double>();
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            amortiz.Clear();
            if ((Validacao(txtTotalVista) && Validacao(txtPeriodo) && Validacao(txtJuros)) == true)
            {
                lblTotalVista.Text = txtTotalVista.Text;
                listView1.Items.Clear();
                if (rbPrice.Checked)
                    metodo('P');
                else
                    metodo('S');
                lblTotalPrazo.Text = (double.Parse(lblTotalJuros.Text) + amortiz[0]).ToString("0.00");
                return;
            }
            MessageBox.Show("Preencha corretamente os valores");
        }

        bool Validacao(TextBox objeto)
        {
            string tempString = objeto.Text.Replace('.', ',');
            double tempDouble;
            if (tempString == "" || tempString == "0" || !(double.TryParse(tempString, out tempDouble)))
                return false;
            if (tempDouble < 0)
                return false;
            amortiz.Add(tempDouble);
            return true;
        }
        void metodo(char opc)
        {//http://pt.wikipedia.org/wiki/Tabela_Price
            amortiz[2] /= 100;
            double restante = amortiz[0];
            double totalJuros = 0;
            for (int n = 0; n < amortiz[1]; n++)
            {   
                double juros = restante * amortiz[2];
                double pmt = (opc == 'P') ? (amortiz[0] * amortiz[2]/ (1 - (1 / Math.Pow(1 + amortiz[2], amortiz[1])))) : (amortiz[0] / amortiz[1] + juros);
                double amortizacao = pmt - juros;
                listView1.Items.Add((n + 1).ToString());
                double[] campos = { restante, amortizacao, juros, amortizacao + juros, restante - amortizacao };
                for (int x = 0; x < campos.Length; x++)
                    listView1.Items[n].SubItems.Add(campos[x].ToString("0.00"));
                restante -= amortizacao;
                totalJuros += juros;
            }
            lblTotalJuros.Text = totalJuros.ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por:\nRicardo Petrére\nRA: 031125940");
        }
    }
}
