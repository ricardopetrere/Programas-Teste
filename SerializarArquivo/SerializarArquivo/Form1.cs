using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializarArquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscarArquivo_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
                txtCaminhoArquivo.Text = openFileDialog1.FileName;
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            //if (File.Exists(txtCaminhoArquivo.Text))
            //{
                //FileInfo fi = new FileInfo(txtCaminhoArquivo.Text);
                //byte[] dados = File.ReadAllBytes(txtCaminhoArquivo.Text);
                //txtDadosArquivo.Text = Convert.ToBase64String(dados);

                string dados = txtDadosArquivo.Text;
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream f = new FileStream(txtCaminhoArquivo.Text,FileMode.Create);
                formatter.Serialize(f,dados);
                f.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Arquivo não existe");
            //}
        }

        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(txtCaminhoArquivo.Text, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            string dados = formatter.Deserialize(stream).ToString();
            stream.Close();
        }
    }
}
