using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AcompanharAnuncios
{
    public partial class frPrincipal
    {
        /// <summary>
        /// Realiza a navegação baseada na url exibida no topo da página
        /// </summary>
        void Navegar()
        {
            Navegar(txtUrl.Text);
        }
        /// <summary>
        /// Realiza a navegação baseada na url passada
        /// </summary>
        /// <param name="url">A URL para a qual o navegador deve ir</param>
        void Navegar(String url)
        {
            if (url.Trim() != "" && Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                webBrowser1.Navigate(url);
        }

        void CriarNodo()
        {
            if (treeAnuncios.Nodes.Count > 0)
            {
                frAdicionarNodo frNovoNodo = new frAdicionarNodo(this, false);
                if (frNovoNodo.ShowDialog() == DialogResult.OK)
                {
                    RealizarLinkagemNodoPaiNodoFilho(frNovoNodo.txtTexto.Text, frNovoNodo.txtLink.Text, frNovoNodo.listView1.SelectedItems[0].Text);
                }
            }
        }
        void CriarNodoNoGrupoAtual()
        {
            if (treeAnuncios.SelectedNode != null)
            {
                String texto_grupo = treeAnuncios.SelectedNode.Parent == null ? treeAnuncios.SelectedNode.Text : treeAnuncios.SelectedNode.Parent.Text;
                RealizarLinkagemNodoPaiNodoFilho(webBrowser1.Document.Title, txtUrl.Text, texto_grupo);
            }
        }
        void RealizarLinkagemNodoPaiNodoFilho(String texto, String link, String texto_gruposelecionado)
        {
            Nodo novoNodo = new Nodo(texto, link);
            foreach (Nodo nodo_pai in nodos)
            {
                if (nodo_pai.Nome == texto_gruposelecionado)
                {
                    nodo_pai.Filhos.Add(novoNodo);
                    novoNodo.Pai = nodo_pai;
                    break;
                }
            }
            AtualizaTreeView(novoNodo);
            AtualizarBotoes();
        }

        void AtualizaTreeView(Nodo novoNodo)
        {
            treeAnuncios.Nodes.Clear();
            foreach (Nodo nodo_pai in nodos)
            {
                TreeNode grupo = new TreeNode(nodo_pai.Nome);
                foreach (Nodo nodo_filho in nodo_pai.Filhos)
                {
                    TreeNode nodo = new TreeNode(nodo_filho.Nome);
                    nodo.Tag = nodo_filho.Link;
                    grupo.Nodes.Add(nodo);
                }
                treeAnuncios.Nodes.Add(grupo);
            }
            treeAnuncios.SelectedNode = treeAnuncios.TopNode;
        }

        /// <summary>
        /// Altera o nodo para entrar em modo de edição de texto
        /// </summary>
        void HabilitarRenomearNodo()
        {
            //Console.WriteLine("Rename Node - KeyDown");
            if (treeAnuncios.SelectedNode != null)
                treeAnuncios.SelectedNode.BeginEdit();
        }

        void RenomearNodo(TreeNode nodo, String novo_texto)
        {
            foreach (Nodo nodo_pai in nodos)
            {
                if (nodo_pai.Nome == nodo.Text)
                {
                    nodo_pai.Nome = novo_texto;
                    break;
                }
                foreach (Nodo nodo_filho in nodo_pai.Filhos)
                {
                    if (nodo_filho.Nome == nodo.Text)
                    {
                        nodo_filho.Nome = novo_texto;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Apaga o nodo atualmente selecionado, após confirmação
        /// </summary>
        void RemoverNodo()
        {
            if (treeAnuncios.SelectedNode != null)
            {
                String mensagem = treeAnuncios.SelectedNode.Parent == null ? "Deseja remover esse grupo e todos os seus links?" : "Deseja mesmo remover esse link?";
                if (MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    foreach (Nodo nodo_pai in nodos)
                    {
                        if (nodo_pai.Nome == treeAnuncios.SelectedNode.Text)
                        {
                            nodos.Remove(nodo_pai);
                            nodo_pai.Pai = null;
                            break;
                        }
                        foreach (Nodo nodo_filho in nodo_pai.Filhos)
                        {
                            if (nodo_filho.Nome == treeAnuncios.SelectedNode.Text
                                && nodo_pai.Nome == treeAnuncios.SelectedNode.Parent.Text)
                            {
                                nodo_pai.Filhos.Remove(nodo_filho);
                                nodo_filho.Pai = null;
                                break;
                            }
                        }
                    }
                    treeAnuncios.Nodes.Remove(treeAnuncios.SelectedNode);
                }
            }
        }
        void RemoverNodoDoGrupoAtual()
        {
            
        }

        void CriarGrupo()
        {
            frAdicionarNodo frNovoGrupo = new frAdicionarNodo(this, true);
            if (frNovoGrupo.ShowDialog() == DialogResult.OK)
            {
                Nodo novoNodo = new Nodo(frNovoGrupo.txtTexto.Text, null);
                nodos.Add(novoNodo);
                AtualizaTreeView(novoNodo);
            }
        }

        void DarFoco(Control control)
        {
            control.Focus();
        }

        void AtualizarBotoes()
        {
            btnAdicionar.Enabled = true;
            btnRemover.Enabled = false;
            if (treeAnuncios.SelectedNode!=null && treeAnuncios.SelectedNode.Tag != null && treeAnuncios.SelectedNode.Tag.ToString() == txtUrl.Text.Trim())
            {
                btnAdicionar.Enabled = false;
                btnRemover.Enabled = true;
            }
        }

        void CarregarArquivo()
        {
            treeAnuncios.Nodes.Clear();
            //if(File.Exists(NOME_ARQUIVO))
        }

        void SalvarArquivo()
        {
            //File.WriteAllLines(NOME_ARQUIVO,)
        }

        public const string NOME_ARQUIVO = "anuncios.sav";
    }
}
