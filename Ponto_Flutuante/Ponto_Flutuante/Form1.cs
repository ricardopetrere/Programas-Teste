using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ponto_Flutuante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MaskedTextBox[] slots = new MaskedTextBox[64];
        double valor;
        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' || e.KeyChar == '1')
            {
                (sender as MaskedTextBox).Text = e.KeyChar.ToString();
                evento(sender);
            }
        }

        private void evento(object sender)
        {
            int maxmantissa = (rbSimples.Checked) ? 32 : 64;
            int minmantissa = (rbSimples.Checked) ? 9 : 12;
            int baseexp = (rbSimples.Checked) ? 127 : 1023;
            int exp = 0;
            if (sender is MaskedTextBox)
            {
                for (int n = minmantissa - 1; n > 0; n--)
                    exp += int.Parse(slots[n].Text) * (int)Math.Pow(2, minmantissa - 1 - n);
                exp -= baseexp;
                double mantissa = 0;
                for (int n = minmantissa; n < maxmantissa; n++)
                    mantissa += int.Parse(slots[n].Text) * Math.Pow(2, -(n - minmantissa + 1));
                valor = Math.Pow(-1, int.Parse(slots[0].Text)) * (1 + mantissa) * Math.Pow(2, exp);
                valor = Math.Round(valor, 8);
                textBox1.Text = valor.ToString();
            }
            else if (sender is TextBox)
            {
                bool negativo = false;
                if (valor < 0)
                {
                    negativo = true;
                    valor *= -1;
                }
                else if (valor == 0)
                {
                    for (int n = 0; n < maxmantissa; n++)
                        slots[n].Text = "0";
                    return;
                }
                else if (rbSimples.Checked && (valor > float.MaxValue || valor < float.MinValue))
                {
                    rbDupla.Checked = true;
                    return;
                }
                for (int n = -baseexp; n < baseexp + 1; n++)
                    if (Math.Pow(2, n) > valor)
                    {
                        exp = n - 1;
                        break;
                    }
                valor -= Math.Pow(2, exp);//tira o primeiro 1
                int inteiro = (int)valor;
                double fracao = valor - inteiro;
                int virgula = minmantissa + exp;
                exp += baseexp;
                slots[0].Text = (negativo) ? "1" : "0";
                for (int n = minmantissa - 2; n >= 0; n--)
                {
                    int subtraindo = (int)Math.Pow(2, n);
                    slots[minmantissa - 1 - n].Text = (subtraindo > exp) ? "0" : "1";
                    exp = (subtraindo > exp) ? exp : exp - subtraindo;
                }
                for (int n = minmantissa; n < maxmantissa; n++)
                {
                    double subtraindo = Math.Pow(2, virgula - n - 1);
                    slots[n].Text = (subtraindo > valor) ? "0" : "1";
                    valor = (subtraindo > valor) ? valor : valor - subtraindo;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!textBox1.Focused)
                return;
            if (double.TryParse(textBox1.Text.Replace('.', ','), out valor))
                evento(textBox1);
            else
                foreach (MaskedTextBox item in slots)
                    item.Text = "0";
        }

        private void rbSimples_CheckedChanged(object sender, EventArgs e)
        {
            valor = double.Parse(textBox1.Text.Replace('.', ','));
            panel1.Visible = !rbSimples.Checked;
            for (int n = 9; n <= 11; n++)
                slots[n].BackColor = rbSimples.Checked ? Color.White : Color.Orange;
            evento(textBox1);
            slots[0].Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control coisa in Controls)
            {
                atribuirslots(coisa);
                if (coisa.Name == "panel1")
                    foreach (Control subcoisa in panel1.Controls)
                        atribuirslots(subcoisa);
            }
        }
        void atribuirslots(Control coisa)
        {
            if (coisa is MaskedTextBox)
            {
                int posicao = int.Parse(coisa.Name.Replace("maskedTextBox", "")) - 1;
                slots[posicao] = (coisa as MaskedTextBox);
            }
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int index = -1;
            for (int n = 0; n < slots.Length; n++)
                if (slots[n].Focused)
                {
                    index = n;
                    break;
                }
            if (index < 0)
                return;
            if (e.KeyCode == Keys.Left)
            {
                if (index > 0)
                    slots[index - 1].Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (index + 1 < ((panel1.Visible) ? 64 : 32))
                    slots[index + 1].Focus();
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if ((sender as MaskedTextBox).Text == "")
                (sender as MaskedTextBox).Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por:\nRicardo Petrére\nRA: 031125940");
        }
    }
}
