using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Cadastrosv2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        int opcao;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Atualizar()
        {
            cbEscolhaCadastro.DataSource = MetodosBD.ExecutaSelect("select * from cadastros order by nome");
            cbEscolhaCadastro.DisplayMember = "nome";
            cbEscolhaCadastro.ValueMember = "id";
            cbEscolhaCadastro.SelectedIndex = -1;
        }

        private void Resetarcampos()
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
            cbEscolhaCadastro.SelectedIndex = -1;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            opcao = 1;
            panEscolhaCadastro.Visible = false;
            panCadastro.Visible = true;
            panCadastro.Enabled = true;
            panOpcoes.Enabled = false;
            panSalvar.Visible = true;
            Resetarcampos();
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
            Resetarcampos();
            panCadastro.Visible = false;
            panEscolhaCadastro.Visible = false;
            panOpcoes.Enabled = true;
            panSalvar.Visible = false;
            errorProvider1.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            CadastroVO c = new CadastroVO();
            c.Id = Convert.ToInt16(cbEscolhaCadastro.SelectedValue);
            c.Nome = txtNome.Text;
            c.Cidade = txtCidade.Text;
            c.Desc_Telefone1 = txtDescTel1.Text;
            c.Desc_Telefone2 = txtDescTel2.Text;
            c.Desc_Telefone3 = txtDescTel3.Text;
            c.Email = txtEmail.Text;
            c.Endereco = txtEndereco.Text;
            c.Num_Telefone1 = txtTel1.Text;
            c.Num_Telefone2 = txtTel2.Text;
            c.Num_Telefone3 = txtTel3.Text;
            c.Data = txtData.Text;
            bool correto = true;
            if (opcao == 2 || opcao == 3)
                if (cbEscolhaCadastro.SelectedIndex < 0)
                {
                    errorProvider1.SetError(cbEscolhaCadastro, "Escolha um cadastro.");
                    return;
                }
            if (opcao == 1)
            {
                int limite = 0;
                if(MetodosBD.ExecutaSelect("select * from cadastros").Rows.Count!=0)
                    limite = Convert.ToInt16(MetodosBD.ExecutaSelect("select max(id) as 'Limite' from cadastros").Rows[0]["Limite"]);
                for (int n = 1; n < limite + 2; n++)
                    if (MetodosBD.ExecutaSelect(string.Format("select * from cadastros where id = {0}", n)).Rows.Count == 0)
                    {
                        c.Id = n;
                        break;
                    }
            }
            if (opcao == 1 || opcao == 3)
            {
                if (txtNome.Text.Trim().Length == 0)
                {
                    errorProvider1.SetError(txtNome, "Nome obrigatório.");
                    correto = false;
                }
                else if (MetodosBD.ExecutaSelect(string.Format("select * from cadastros where nome='{0}' and id != {1}",c.Nome,c.Id)).Rows.Count != 0)
                {
                    errorProvider1.SetError(txtNome, "Cadastro já existente");
                    correto = false;
                }
            }
            if (correto)
            {
                try
                {
                    switch (opcao)
                    {
                        case 1:
                            CadastroDAO.Adicionar(c);
                            MessageBox.Show("Cadastro adicionado.");
                            break;
                        case 2:
                            CadastroDAO.Remover(Convert.ToInt16(cbEscolhaCadastro.SelectedValue));
                            MessageBox.Show("Cadastro removido.");
                            break;
                        case 3:
                            CadastroDAO.Editar(c);
                            MessageBox.Show("Cadastro editado.");
                            break;
                    }
                    Atualizar();
                    Resetarcampos();
                }
                catch
                {

                }
            }
        }

        private void cbEscolhaCadastro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CadastroVO c = CadastroDAO.MontarVO(MetodosBD.ExecutaSelect("select * from cadastros where id=" + cbEscolhaCadastro.SelectedValue.ToString()).Rows[0]);
            txtNome.Text = c.Nome;
            txtData.Text = c.Data;
            txtEmail.Text = c.Email;
            txtEndereco.Text = c.Endereco;
            txtCidade.Text = c.Cidade;
            txtTel1.Text = c.Num_Telefone1;
            txtDescTel1.Text = c.Desc_Telefone1;
            txtTel2.Text = c.Num_Telefone2;
            txtDescTel2.Text = c.Desc_Telefone2;
            txtTel3.Text = c.Num_Telefone3;
            txtDescTel3.Text = c.Desc_Telefone3;
        }
    }
}
