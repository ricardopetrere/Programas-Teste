using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Forca
{
    public partial class Forca : Form
    {
        public Forca()
        {
            InitializeComponent();
        }
        int QtdeErros = 0;
        string PalavraCorreta;
        bool Jogando = false;
        char[] PalavraCompleta;
        string[] arquivos = { @"base\picForca.png", @"base\pic1.png", @"base\pic2.png", @"base\pic3.png", @"base\pic4.png", @"base\pic5.png", @"base\palavras.txt" };

        private void txtPalavra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Jogando)
            {
                char letra = e.KeyChar;
                bool contem = false;
                for (int n = 0; n < PalavraCorreta.Length; n++)
                {
                    char varChar = PalavraCorreta[n];
                    if ((varChar == 'a' || varChar == 'ã' || varChar == 'á' || varChar == 'â') && (letra == 'a' || letra == 'ã' || letra == 'á' || letra == 'â'))
                        contem = atribuir(n);
                    else if ((varChar == 'e' || varChar == 'é' || varChar == 'ê') && (letra == 'e' || letra == 'é' || letra == 'ê'))
                        contem = atribuir(n);
                    else if ((varChar == 'i' || varChar == 'í') && (letra == 'i' || letra == 'í'))
                        contem = atribuir(n);
                    else if ((varChar == 'o' || varChar == 'õ' || varChar == 'ô' || varChar == 'ó') && (letra == 'o' || letra == 'õ' || letra == 'ô' || letra == 'ó'))
                        contem = atribuir(n);
                    else if ((varChar == 'u' || varChar == 'ú') && (letra == 'u' || letra == 'ú'))
                        contem = atribuir(n);
                    else if (varChar == letra)
                        contem = atribuir(n);
                }
                txtPalavra.Clear();
                foreach (char varChar in PalavraCompleta)
                    txtPalavra.Text += varChar.ToString();
                if (contem == false)
                    if (!txtErros.Text.Contains(letra))
                    {
                        txtErros.Text += letra.ToString();
                        QtdeErros++;
                    }
                picForca.ImageLocation = arquivos[QtdeErros];
                if (QtdeErros == 5 || (!txtPalavra.Text.Contains('_')))
                {
                    MessageBox.Show((QtdeErros == 5) ? ("GAME OVER") : ("Parabéns"));
                    preparar();
                }
            }
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            Random sortear = new Random();
            string[] temp = File.ReadAllText(arquivos[6], Encoding.UTF8).Split('|');
            PalavraCorreta = temp[sortear.Next(temp.Length)];
            PalavraCompleta = new char[PalavraCorreta.Length];
            preparar();
            this.Focus();
        }

        void preparar()
        {
            Jogando = !Jogando;
            btnComecar.Enabled = !btnComecar.Enabled;
            txtPalavra.Text = "";
            txtErros.Text = "";
            QtdeErros = 0;
            picForca.ImageLocation = arquivos[0];
            if (Jogando)
                for (byte n = 0; n < PalavraCorreta.Length; n++)
                {
                    txtPalavra.Text = (PalavraCorreta[n] != ' ') ? (txtPalavra.Text + "_") : (txtPalavra.Text + " ");
                    PalavraCompleta[n] = (PalavraCorreta[n] != ' ') ? ('_') : (' ');
                }
        }

        private void Forca_Load(object sender, EventArgs e)
        {
            foreach (string arquivo in arquivos)
                if (!File.Exists(arquivo))
                {
                    MessageBox.Show("Impossível rodar programa. Falta de arquivos");
                    Close();
                }
        }

        bool atribuir(int index)
        {
            PalavraCompleta[index] = PalavraCorreta[index];
            return true;
        }
    }
}
