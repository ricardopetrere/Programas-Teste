using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Cadastrosv2
{
    public partial class frmPrincipal : Form
    {
        /*
        
        para tentar: extender form in-debug:
        width=368
        height1 = 134
        height2 = 175
        height3 = 416
        
       
        */
        public frmPrincipal()
        {
            InitializeComponent();
        }
        string arquivo = @"cadastros.txt";
        string[] linhas;
        int opcao;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            atualizar();
        }

        private void atualizar()
        {
            linhas = File.ReadAllLines(arquivo, Encoding.UTF8);
            cbEscolhaCadastro.Items.Clear();
            for (int n = 0; n < linhas.Length; n++)
                cbEscolhaCadastro.Items.Add(linhas[n].Substring(0, linhas[n].IndexOf('|')));
        }

        private void resetarcampos()
        {
            txtNome.Clear();
            txtData.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtCidade.Clear();
            txtTel1.Clear();
            txtTel2.Clear();
            txtTel3.Clear();
            txtDescTel1.Clear();
            txtDescTel2.Clear();
            txtDescTel3.Clear();
        }

        private void ordenar()
        {
            linhas = File.ReadAllLines(arquivo, Encoding.UTF8);
            string[] final = new string[linhas.Length];
            int num = 0;
            for (int n = 65; n < 91; n++)
                for (int x = 0; x < linhas.Length; x++)
                    if (Convert.ToInt16(linhas[x].ToUpper()[0]) == n)
                    {
                        final[num] = linhas[x];
                        num++;
                    }
            linhas = final;
            File.Delete(@"cadastros.txt");
            for (int n = 0; n < linhas.Length; n++)
                File.AppendAllText(@"cadastros.txt", linhas[n] + Environment.NewLine, Encoding.UTF8);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            opcao = 1;
            panCadastro.Visible = true;
            panCadastro.Enabled = true;
            panOpcoes.Enabled = false;
            panSalvar.Visible = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            opcao = 2;
            panEscolhaCadastro.Visible = true;
            panCadastro.Visible = true;
            panCadastro.Enabled = false;
            panOpcoes.Enabled = false;
            panSalvar.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            opcao = 3;
            panEscolhaCadastro.Visible = true;
            panCadastro.Visible = true;
            panCadastro.Enabled = true;
            panOpcoes.Enabled = false;
            panSalvar.Visible = true;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            panEscolhaCadastro.Visible = true;
            panCadastro.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetarcampos();
            panCadastro.Visible = false;
            panEscolhaCadastro.Visible = false;
            panOpcoes.Enabled = true;
            panSalvar.Visible = false;
            errorProvider1.Clear();
            atualizar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (opcao == 1)
            {
                if (txtNome.Text.Trim().Length == 0)
                    errorProvider1.SetError(txtNome, "Nome obrigatório.");
                else
                {
                    errorProvider1.Clear();
                    for(int n=0;n<linhas.Length;n++)
                        if (cbEscolhaCadastro.Items[n].ToString().Trim() == txtNome.Text)
                        {
                            MessageBox.Show("Esse cadastro já existe.");
                            return;
                        }
                    File.AppendAllText(arquivo, txtNome.Text + "|", Encoding.UTF8);
                    File.AppendAllText(arquivo, txtData.Text + "|", Encoding.UTF8);
                    File.AppendAllText(arquivo, txtEmail.Text + "|", Encoding.UTF8);
                    File.AppendAllText(arquivo, txtEndereco.Text + "|", Encoding.UTF8);
                    File.AppendAllText(arquivo, txtCidade.Text + "|", Encoding.UTF8);
                    File.AppendAllText(arquivo, txtTel1.Text + "|", Encoding.UTF8);
                    File.AppendAllText(arquivo, txtDescTel1.Text + "|", Encoding.UTF8);
                    File.AppendAllText(arquivo, txtTel2.Text + "|", Encoding.UTF8);
                    File.AppendAllText(arquivo, txtDescTel2.Text + "|", Encoding.UTF8);
                    File.AppendAllText(arquivo, txtTel3.Text + "|", Encoding.UTF8);
                    File.AppendAllText(arquivo, txtDescTel3.Text + Environment.NewLine, Encoding.UTF8);
                    MessageBox.Show("Cadastro salvo.");
                }
            }
            else if (opcao == 2)
            {
                if (cbEscolhaCadastro.SelectedIndex < 0)
                    errorProvider1.SetError(cbEscolhaCadastro, "Escolha um cadastro.");
                else
                {
                    errorProvider1.Clear();
                    File.Delete(arquivo);
                    for (int n = 0; n < linhas.Length; n++)
                        if (n != cbEscolhaCadastro.SelectedIndex)
                            File.AppendAllText(arquivo, linhas[n] + Environment.NewLine, Encoding.UTF8);
                    MessageBox.Show("Cadastro removido.");
                }
            }
            else if (opcao == 3)
            {
                if (txtNome.Text.Trim().Length == 0 || cbEscolhaCadastro.SelectedIndex < 0)
                {
                    if (txtNome.Text.Trim().Length == 0)
                        errorProvider1.SetError(txtNome, "Nome obrigatório.");
                    if (cbEscolhaCadastro.SelectedIndex < 0)
                        errorProvider1.SetError(cbEscolhaCadastro, "Escolha um cadastro.");
                }
                else
                {
                    errorProvider1.Clear();
                    linhas[cbEscolhaCadastro.SelectedIndex] = txtNome.Text + "|" + txtData.Text + "|" + txtEmail.Text + "|" +
                        txtEndereco.Text + "|" + txtCidade.Text + "|" + txtTel1.Text + "|" + txtDescTel1.Text + "|" +
                        txtTel2.Text + "|" + txtDescTel2.Text + "|" + txtTel3.Text + "|" + txtDescTel3.Text;
                    File.Delete(arquivo);
                    for (int n = 0; n < linhas.Length; n++)
                        File.AppendAllText(arquivo, linhas[n] + Environment.NewLine, Encoding.UTF8);
                    MessageBox.Show("Cadastro editado.");
                }
            }
            ordenar();
            atualizar();
            resetarcampos();
        }

        private void cbEscolhaCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] campos = linhas[cbEscolhaCadastro.SelectedIndex].Split('|');
            txtNome.Text = campos[0];
            txtData.Text = campos[1];
            txtEmail.Text = campos[2];
            txtEndereco.Text = campos[3];
            txtCidade.Text = campos[4];
            txtTel1.Text = campos[5];
            txtDescTel1.Text = campos[6];
            txtTel2.Text = campos[7];
            txtDescTel2.Text = campos[8];
            txtTel3.Text = campos[9];
            txtDescTel3.Text = campos[10];
        }

        

        
    }
}
