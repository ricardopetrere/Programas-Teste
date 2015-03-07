using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AcompanharAnuncios
{
    public partial class frAdicionarNodo : Form
    {
        public frAdicionarNodo(frPrincipal tela_pai,bool IsCriarGrupo)
        {
            InitializeComponent();
            //Dimensões para criação de nodo: 290x240
            //Dimensões para criação de grupo:290x110
            if(!IsCriarGrupo)
            {
                Height=240;
                pnlItensdeCriacaoDeNodo.Enabled = true;
                pnlItensdeCriacaoDeNodo.Visible = true;
                Text = "Adicionar Link";
                listView1.Items.Clear();
                foreach (Nodo nodo_pai in tela_pai.nodos)
                {
                    ListViewGroup grp = new ListViewGroup(nodo_pai.Nome);
                    listView1.Groups.Add(grp);
                    foreach (Nodo nodo_filho in nodo_pai.Filhos)
                    {
                        ListViewItem itm = new ListViewItem(nodo_filho.Nome, grp);
                        itm.Tag = nodo_filho.Link;
                        listView1.Items.Add(itm);
                    }
                }
            }
            else
            {
                Height = 110;
                pnlItensdeCriacaoDeNodo.Enabled = false;
                pnlItensdeCriacaoDeNodo.Visible = false;
                Text = "Adicionar Grupo";
            }
        }

        private void frAdicionarNodo_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Validações
            errorProvider1.Clear();
            bool IsValido = true;
            if (txtTexto.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTexto, "Preencher o campo");
                IsValido = false;
            }
            //Se for pra criar nodo (filho), então deve validar estes itens
            if(pnlItensdeCriacaoDeNodo.Enabled==true)
            {
                if (txtLink.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtLink, "Preencher o campo");
                    IsValido = false;
                }
                if (listView1.SelectedItems.Count <= 0)//Como só dá para selecionar um grupo, essa validação basta
                {
                    errorProvider1.SetError(listView1, "Selecione um grupo");
                    IsValido = false;
                }
            }
            if(IsValido)
                //Enfim, voltar pra tela inicial
                DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
    }
}
