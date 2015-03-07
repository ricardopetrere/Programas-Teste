using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Sudoku
{
    public partial class frSalvar : Form
    {
        public frSalvar()
        {
            InitializeComponent();
        }
        public string nome;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            nome = "mapas\\"+textBox1.Text + ".rec";
            if (File.Exists(nome))
            {
                MessageBox.Show("Arquivo já existe");
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('.'))
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.IndexOf('.'));
        }
    }
}
