using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RenomeiaExtensão
{
    public partial class frAlterarExtensoes : Form
    {
        public frAlterarExtensoes()
        {
            InitializeComponent();
        }
        String[] arquivos;

        private void btnSelecionarPasta_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                txtCaminhoPasta.Text = folderBrowserDialog1.SelectedPath;
                ListarArquivos();
            }
        }

        private void btnAlterarExtensoes_Click(object sender, EventArgs e)
        {
            txtExtensaoOrigem.Text = txtExtensaoOrigem.Text.Trim();
            txtExtensaoDestino.Text = txtExtensaoDestino.Text.Trim();

            try
            {
                foreach (string arquivo in arquivos)
                {
                    String antigaextensao = "";
                    String novaextensao = "." + txtExtensaoDestino.Text;

                    if (arquivo.IndexOf('.') < 0)
                        antigaextensao = ".";
                    else
                        antigaextensao = arquivo.Substring(arquivo.IndexOf('.'));
                    String novoarquivo;
                    if (arquivo.IndexOf('.') < 0)
                        novoarquivo = arquivo + novaextensao;
                    else
                        novoarquivo = arquivo.Replace(arquivo.Substring(arquivo.IndexOf(antigaextensao)), novaextensao);
                    if (antigaextensao == "."+txtExtensaoOrigem.Text)
                    {
                        File.Move(arquivo, novoarquivo);
                    }
                }
                MessageBox.Show("Sucesso.");
            }
            catch
            {
                MessageBox.Show("Erro ao renomear um ou mais arquivos. Verifique.");
            }
            ListarArquivos();
        }
        void ListarArquivos()
        {
            arquivos = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.*", SearchOption.TopDirectoryOnly);
            lbArquivosPasta.Items.Clear();
            foreach (string item in arquivos)
            {
                lbArquivosPasta.Items.Add(item);
            }
        }

        private void frAlterarExtensoes_Load(object sender, EventArgs e)
        {
            //Debug
            //txtCaminhoPasta.Text = @"C:\Games\Steam\SteamApps\common\Age of Mythology\savegame";
            //folderBrowserDialog1.SelectedPath = @"C:\Games\Steam\SteamApps\common\Age of Mythology\savegame";
            //ListarArquivos();
        }

        private void btnAtualizarListagem_Click(object sender, EventArgs e)
        {
            ListarArquivos();
        }
    }
}
