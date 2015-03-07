using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Exercicio_Criptografia
{
    public partial class Form1 : Form
    {
        #region Eventos
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Application.StartupPath;
        }

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            //openFileDialog1
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoArquivo.Text = openFileDialog1.FileName;
            }
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            //criptografar
            if (txtCaminhoArquivo.Text.Trim() != "")
            {
                if (string.IsNullOrWhiteSpace(txtTexto.Text))
                {
                    errorProvider1.SetError(txtTexto, "Preencha o campo.");
                }
                else if (rbCifraCesar.Checked)
                {
                    if (NaoPossuiApenasNumeros(txtChave.Text))
                    {
                        errorProvider1.SetError(txtChave, "Chave inválida.");
                    }
                    else if (ContemCaracteresInvalidos(txtTexto.Text))
                    {
                        errorProvider1.SetError(txtTexto, "Texto possui caracteres inválidos.");
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(txtChave.Text))
                        {
                            errorProvider1.SetError(txtChave, "Preencha o campo.");
                        }
                        else
                        {
                            File.WriteAllText(txtCaminhoArquivo.Text, Criptografar_Cesar(txtTexto.Text, Convert.ToInt32(txtChave.Text)));
                            MessageBox.Show("Arquivo salvo.");
                        }
                    }
                }
                else if (rbVigenere.Checked)
                {
                    if (NaoPossuiApenasLetrasMaiusculas(txtTexto.Text))
                    {
                        errorProvider1.SetError(txtTexto, "Texto possui caracteres inválidos com a cifra");
                    }
                    else if (NaoPossuiApenasLetrasMaiusculas(txtChave.Text))
                    {
                        errorProvider1.SetError(txtChave, "Chave inválida.");
                    }
                    else if (ContemCaracteresInvalidos(txtTexto.Text))
                    {
                        errorProvider1.SetError(txtTexto, "Texto possui caracteres inválidos.");
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(txtChave.Text))
                        {
                            errorProvider1.SetError(txtChave, "Preencha o campo.");
                        }
                        else
                        {
                            File.WriteAllText(txtCaminhoArquivo.Text, Criptografar_Vigenere(txtTexto.Text, txtChave.Text));
                            MessageBox.Show("Arquivo salvo.");
                        }
                    }
                }
                else
                    MessageBox.Show("Selecione um tipo de cifra.");
            }
            else
            {
                errorProvider1.SetError(txtCaminhoArquivo, "Preencha o nome do arquivo.");
            }

        }

        private void btnDecriptografar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            //decriptografar
            if (txtCaminhoArquivo.Text.Trim() != "")
            {
                if (!File.Exists(txtCaminhoArquivo.Text.Trim()))
                {
                    errorProvider1.SetError(txtCaminhoArquivo, "O arquivo não foi encontrado.");
                }
                else if (rbCifraCesar.Checked)
                {
                    if (NaoPossuiApenasNumeros(txtChave.Text))
                    {
                        errorProvider1.SetError(txtChave, "Chave inválida.");
                        return;
                    }
                    else
                    {
                        txtTexto.Text = Decriptografar_Cesar(File.ReadAllText(txtCaminhoArquivo.Text), Convert.ToInt32(txtChave.Text));
                    }
                }
                else if (rbVigenere.Checked)
                {
                    if (NaoPossuiApenasLetrasMaiusculas(txtChave.Text))
                    {
                        errorProvider1.SetError(txtChave, "Chave inválida.");
                    }
                    else
                    {
                        txtTexto.Text = Decriptografar_Vigenere(File.ReadAllText(txtCaminhoArquivo.Text), txtChave.Text);
                    }
                }
                else
                    MessageBox.Show("Selecione um tipo de cifra.");
            }
            else
            {
                errorProvider1.SetError(txtCaminhoArquivo, "Preencha o nome do arquivo.");
            }
        }
        #endregion
        #region Cesar
        /// <summary>
        /// Criptografa um texto usando a cifra de César
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        String Criptografar_Cesar(String texto, int chave)
        {
            char[] retorno = new char[texto.Length];
            for (int n = 0; n < texto.Length; n++)
            {
                retorno[n] = (char)((int)texto[n] + chave);
            }

            return new string(retorno);
        }

        /// <summary>
        /// Decriptografa um texto usando a cifra de César
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        String Decriptografar_Cesar(String texto, int chave)
        {
            char[] retorno = new char[texto.Length];
            for (int n = 0; n < texto.Length; n++)
            {
                retorno[n] = (char)((int)texto[n] - chave);
            }

            return new string(retorno);
        }
        #endregion
        #region Vigenere
        /// <summary>
        /// Criptografa um texto usando a Cifra de Vigenère
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        String Criptografar_Vigenere(String texto, String chave)
        {
            AjustaChaveVigenere(texto.Length, ref chave);
            char[] retorno = new char[texto.Length];
            for (int n = 0; n < texto.Length; n++)
            {
                //int a = (texto[n] - 65);
                //int b = (chave[n] - 65);
                //int c = ((a + b) % 26) + 65;
                //retorno[n] = (char)c;
                retorno[n] = (char)((((texto[n] + chave[n]) % 65) % 26) + 65);
            }
            return new string(retorno);
        }

        /// <summary>
        /// Decriptografa um texto usando a Cifra de Vigenère
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        String Decriptografar_Vigenere(String texto, String chave)
        {
            AjustaChaveVigenere(texto.Length, ref chave);
            char[] retorno = new char[texto.Length];
            for (int n = 0; n < texto.Length; n++)
            {
                //int a = (texto[n]);
                //int b = (chave[n]);
                //int c = (((a - b) + 26) % 26) + 65;
                //retorno[n] = (char)c;
                retorno[n] = (char)((((texto[n] - chave[n]) + 26) % 26) + 65);
            }
            return new string(retorno);
        }
        #endregion
        #region Validacoes
        bool NaoPossuiApenasLetrasMaiusculas(String texto)
        {
            return ValidaFaixaDeValoresEmCaracteres(texto, 65 /*A*/, 90 /*Z*/);
        }
        bool NaoPossuiApenasNumeros(String texto)
        {
            return ValidaFaixaDeValoresEmCaracteres(texto, 48 /*0*/, 57 /*9*/);
        }
        bool ValidaFaixaDeValoresEmCaracteres(String texto, int minimo, int maximo)
        {
            foreach (char caract in texto.ToCharArray())
            {
                if (
                    (int)caract < minimo
                    ||
                    (int)caract > maximo
                    )
                {
                    return true;
                }
            }
            return false;
        }
        void AjustaChaveVigenere(int tamanho_texto, ref String chave)
        {
            if (chave.Length < tamanho_texto)
            {
                for (int n = 0; chave.Length < tamanho_texto; n++)
                {
                    chave += chave[n % chave.Length];
                }
            }
        }

        private bool ContemCaracteresInvalidos(string texto)
        {
            texto = texto.Replace(" ", "");
            foreach (char caract in texto.ToCharArray())
            {
                if (
                    (int)caract < 48
                    ||
                    ((int)caract > 57 && (int)caract < 65)
                    ||
                    (int)caract > 90
                    )
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
