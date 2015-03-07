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
    public partial class frPrincipal : Form
    {
        public frPrincipal()
        {
            InitializeComponent();
        }

        public List<Nodo> nodos = new List<Nodo>();

        private void treeAnuncios_ControlAdded(object sender, ControlEventArgs e)
        {
            Console.WriteLine("treeAnuncios_ControlAdded");
        }

        private void treeAnuncios_ControlRemoved(object sender, ControlEventArgs e)
        {
            Console.WriteLine("treeAnuncios_ControlRemoved");
        }

        private void treeAnuncios_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Console.WriteLine("treeAnuncios_NodeMouseClick");
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                treeAnuncios.SelectedNode = e.Node;
        }

        private void treeAnuncios_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            Console.WriteLine("treeAnuncios_QueryContinueDrag");
        }

        private void treeAnuncios_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null && e.Node.Tag.ToString().Trim() != "")
                Navegar(e.Node.Tag.ToString());
        }

        private void treeAnuncios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                HabilitarRenomearNodo();
            }
            else if (e.KeyCode == Keys.Enter)
                treeAnuncios_AfterSelect(sender, new TreeViewEventArgs(treeAnuncios.SelectedNode));
            else if (e.KeyCode == Keys.Delete)
                RemoverNodo();

        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Navegar();
        }

        private void toolCriarNodo_Click(object sender, EventArgs e)
        {
            CriarNodo();
        }

        private void toolApagarNodo_Click(object sender, EventArgs e)
        {
            RemoverNodo();
        }

        private void toolRenomearNodo_Click(object sender, EventArgs e)
        {
            HabilitarRenomearNodo();
        }

        private void toolCriarGrupo_Click(object sender, EventArgs e)
        {
            CriarGrupo();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            txtUrl.Text = webBrowser1.Url.AbsoluteUri;
        }

        private void treeAnuncios_MouseEnter(object sender, EventArgs e)
        {
            //DarFoco(treeAnuncios);
        }

        private void treeAnuncios_MouseLeave(object sender, EventArgs e)
        {
            //DarFoco(GetChildAtPoint(MousePosition));
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            Navegar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CriarNodoNoGrupoAtual();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            RemoverNodoDoGrupoAtual();
        }

        private void treeAnuncios_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            RenomearNodo(e.Node,e.Label);
        }

        private void frPrincipal_Load(object sender, EventArgs e)
        {
            CarregarArquivo();
            AtualizarBotoes();
        }

        private void frPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            SalvarArquivo();
        }
    }
}
