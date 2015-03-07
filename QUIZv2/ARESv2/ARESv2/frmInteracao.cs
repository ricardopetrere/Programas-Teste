using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ARESv2
{
    public partial class frmInteracao : Form
    {
        public int interacao;
        const string arquivo=@"quiz.txt";
        string[] linhas = File.ReadAllLines(arquivo, Encoding.UTF8);
        
        public frmInteracao()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmInteracao_Load(object sender, EventArgs e)
        {
            if (interacao == 1)
                adicionar();
            else if (interacao == 2)
                remover();
            else if (interacao == 3)
                editar();
            atualizar();
        }
        private void atualizar()
        {
            cbMostrarPerguntas.Items.Clear();
            cbTema.Items.Clear();
            cbTema.Items.Add("-- novo tema --");
            for (int n = 0; n < linhas.Length; n++)
            {
                string[] questao = linhas[n].Split('|');
                bool jacadastrado = false;
                for (int m = 1; m < cbTema.Items.Count; m++)
                    if (cbTema.Items[m].ToString() == questao[1].Trim())
                        jacadastrado = true;
                if (!jacadastrado)
                    cbTema.Items.Add(questao[1].Trim());
                cbMostrarPerguntas.Items.Add(questao[0].Trim());
            }
        }

        private void adicionar()
        {
            Text = "Adicionar pergunta";
            btnSalvar.Text = "&Adicionar";
            panMostrarPerguntas.Visible = false;
        }
        
        private void remover()
        {
            panPergunta.Enabled = false;
            Text = "Remover pergunta";
            btnSalvar.Text = "&Remover";
        }
        
        private void editar()
        {
            Text = "Editar pergunta";
            btnSalvar.Text = "&Editar";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (interacao == 1)
            {
                if (txtPergunta.Text.Trim().Length == 0 || txtA.Text.Trim().Length == 0 || txtB.Text.Trim().Length == 0
                    || txtC.Text.Trim().Length == 0 || txtD.Text.Trim().Length == 0 || cbTema.SelectedIndex < 0)
                    MessageBox.Show("Termine propriamente o cadastro.");
                else
                {
                    string[] dados = new string[7];
                    try
                    {
                        dados[0] = txtPergunta.Text.Trim();
                        if (cbTema.SelectedIndex==0)
                        {
                            dados[1] = txtNovoTema.Text.Trim();
                            cbTema.Items.Add(txtNovoTema.Text.Trim());
                        }
                        else
                            dados[1] = cbTema.Items[cbTema.SelectedIndex].ToString();
                        if (rbA.Checked)
                            dados[2] = txtA.Text.Trim();
                        else if (rbB.Checked)
                            dados[2] = txtB.Text.Trim();
                        else if (rbC.Checked)
                            dados[2] = txtC.Text.Trim();
                        else if (rbD.Checked)
                            dados[2] = txtD.Text.Trim();
                        else
                        {
                            MessageBox.Show("Escolha uma das alternativas como resposta correta.");
                            return;
                        }
                        dados[3] = txtA.Text.Trim();
                        dados[4] = txtB.Text.Trim();
                        dados[5] = txtC.Text.Trim();
                        dados[6] = txtD.Text.Trim();
                    }
                    catch
                    {
                        MessageBox.Show("Termine propriamente o cadastro.");
                        return;
                    }
                    for (int n = 0; n < 7; n++)
                    {
                        if (n == 6)
                            File.AppendAllText(arquivo, dados[6] + Environment.NewLine, Encoding.UTF8);
                        else
                            File.AppendAllText(arquivo, dados[n] + "|", Encoding.UTF8);
                    }
                    MessageBox.Show("Questão salva.");
                    atualizar();
                }
            }


            else if (interacao == 2)
            {
                File.Delete(arquivo);
                for (int n = 0; n < linhas.Length; n++)
                {
                    if (n == cbMostrarPerguntas.SelectedIndex)
                    {
                        continue;
                    }
                    File.AppendAllText(arquivo, linhas[n] + Environment.NewLine, Encoding.UTF8);
                }
                MessageBox.Show("Questão removida.");
                linhas = File.ReadAllLines(arquivo, Encoding.UTF8);
                atualizar();
            }



            else if (interacao == 3)
            {
                if (txtPergunta.Text.Trim().Length == 0 || txtA.Text.Trim().Length == 0 || txtB.Text.Trim().Length == 0
                    || txtC.Text.Trim().Length == 0 || txtD.Text.Trim().Length == 0 || cbTema.SelectedIndex < 0)
                    MessageBox.Show("Termine propriamente o cadastro.");
                else
                {
                    string[] dados = new string[7];
                    try
                    {
                        dados[0] = txtPergunta.Text.Trim();
                        if (cbTema.SelectedIndex == 0)
                        {
                            dados[1] = txtNovoTema.Text.Trim();
                            cbTema.Items.Add(txtNovoTema.Text.Trim());
                        }
                        else
                            dados[1] = cbTema.Items[cbTema.SelectedIndex].ToString();
                        if (rbA.Checked)
                            dados[2] = txtA.Text.Trim();
                        else if (rbB.Checked)
                            dados[2] = txtB.Text.Trim();
                        else if (rbC.Checked)
                            dados[2] = txtC.Text.Trim();
                        else if (rbD.Checked)
                            dados[2] = txtD.Text.Trim();
                        else
                        {
                            MessageBox.Show("Escolha uma das alternativas como resposta correta.");
                            return;
                        }
                        dados[3] = txtA.Text.Trim();
                        dados[4] = txtB.Text.Trim();
                        dados[5] = txtC.Text.Trim();
                        dados[6] = txtD.Text.Trim();
                    }
                    catch
                    {
                        MessageBox.Show("Termine propriamente o cadastro.");
                        return;
                    }
                    File.Delete(arquivo);
                    for (int n = 0; n < linhas.Length; n++)
                    {
                        if (n == cbMostrarPerguntas.SelectedIndex)
                        {
                            linhas[n] = "";
                            for (int x = 0; x < 7; x++)
                                if (x == 6)
                                    linhas[n] += dados[x];
                                else
                                linhas[n] += dados[x] + "|";
                        }
                        File.AppendAllText(arquivo, linhas[n] + Environment.NewLine, Encoding.UTF8);
                    }
                    MessageBox.Show("Questão alterada.");
                }   
            }
            linhas = File.ReadAllLines(arquivo, Encoding.UTF8);
            atualizar();
        }

        private void cbTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTema.SelectedIndex == 0)
                txtNovoTema.Visible = true;
            else
                txtNovoTema.Visible = false;
        }

        private void cbMostrarPerguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] dados = linhas[cbMostrarPerguntas.SelectedIndex].Split('|');
            txtPergunta.Text = dados[0].Trim();
            for (int n = 0; n < cbTema.Items.Count; n++)
                if (cbTema.Items[n].ToString() == dados[1].Trim())
                    cbTema.SelectedIndex = n;
            txtA.Text = dados[3].Trim();
            txtB.Text = dados[4].Trim();
            txtC.Text = dados[5].Trim();
            txtD.Text = dados[6].Trim();
            if (dados[2].Trim() == dados[3].Trim())
                rbA.Checked = true;
            else if (dados[2].Trim() == dados[4].Trim())
                rbB.Checked = true;
            else if (dados[2].Trim() == dados[5].Trim())
                rbC.Checked = true;
            else if (dados[2].Trim() == dados[6].Trim())
                rbD.Checked = true;
        }

        private string[] atribuirdados()
        {
            string[] dados = new string[7];
            if (txtPergunta.Text.Trim().Length == 0 || txtA.Text.Trim().Length == 0 || txtB.Text.Trim().Length == 0
                    || txtC.Text.Trim().Length == 0 || txtD.Text.Trim().Length == 0 || cbTema.SelectedIndex < 0)
                MessageBox.Show("Termine propriamente o cadastro.");
            else
            {
                try
                {
                    dados[0] = txtPergunta.Text.Trim();
                    if (cbTema.SelectedIndex == 0)
                    {
                        dados[1] = txtNovoTema.Text.Trim();
                        cbTema.Items.Add(txtNovoTema.Text.Trim());
                    }
                    else
                        dados[1] = cbTema.Items[cbTema.SelectedIndex].ToString();
                    if (rbA.Checked)
                        dados[2] = txtA.Text.Trim();
                    else if (rbB.Checked)
                        dados[2] = txtB.Text.Trim();
                    else if (rbC.Checked)
                        dados[2] = txtC.Text.Trim();
                    else if (rbD.Checked)
                        dados[2] = txtD.Text.Trim();
                    else
                    {
                        MessageBox.Show("Escolha uma das alternativas como resposta correta.");
                        return null;
                    }
                    dados[3] = txtA.Text.Trim();
                    dados[4] = txtB.Text.Trim();
                    dados[5] = txtC.Text.Trim();
                    dados[6] = txtD.Text.Trim();
                }
                catch
                {
                    MessageBox.Show("Termine propriamente o cadastro.");
                    return null;
                }
            }
            return dados;
        }
    }
}
