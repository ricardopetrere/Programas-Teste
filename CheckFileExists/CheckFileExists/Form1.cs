using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CheckFileExists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        //Buscar
        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
                textBox1.Text = openFileDialog1.FileName;
        }

        //Importar
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = (textBox1.Text.Trim() == "") ? "" : File.ReadAllText(openFileDialog1.FileName);
        }

        //Exportar
        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()!="")
                File.WriteAllText(textBox1.Text, textBox2.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            openFileDialog1.CheckFileExists = checkBox1.Checked;
        }
    }
}
