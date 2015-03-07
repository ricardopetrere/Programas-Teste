using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastreaProduto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string pedido)
        {
            InitializeComponent();
            textBox1.Text = pedido;
            button1_Click(button1, new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://websro.correios.com.br/sro_bin/txect01$.Inexistente?P_LINGUA=001&P_TIPO=002&P_COD_LIS=" + textBox1.Text.Trim());
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 25;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }
    }
}
