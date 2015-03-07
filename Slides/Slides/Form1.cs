using System;
using System.Linq;
using System.Windows.Forms;

namespace Slides
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string[] arrayimagens = null;
        public static int index = -1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            alterartimer();
            if (arrayimagens == null||index<0)
            {
                MessageBox.Show("Selecione arquivos para mostrar");
                return;
            }
            AbrirImagem();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            alterartimer();
            frmConfiguracao configurar = new frmConfiguracao();
            if (configurar.ShowDialog() == DialogResult.OK)
            {
                lbImagens.ClearSelected();
                pictureBox1.ImageLocation = "";
                lbImagens.Items.Clear();
                timer1.Interval = frmConfiguracao.timer;
                if (frmConfiguracao.imagens == null)
                    frmConfiguracao.imagens = new string[0];
                AdicionarImagens(frmConfiguracao.imagens);
            }
        }

        private void btnComeçar_Click(object sender, EventArgs e)
        {
            if (lbImagens.Items.Count == 0)
                return;
            timer1.Enabled = !timer1.Enabled;
            alterartimer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            index = (index >= lbImagens.Items.Count - 1) ? (0) : (index + 1);
            lbImagens.SelectedIndex = index;
        }

        private void lbImagens_DragEnter(object sender, DragEventArgs e)
        {
            //http://www.jonasjohn.de/snippets/csharp/drag-and-drop-example.htm
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lbImagens_DragDrop(object sender, DragEventArgs e)
        {
            //http://www.jonasjohn.de/snippets/csharp/drag-and-drop-example.htm
            try
            {
                AdicionarImagens((string[])e.Data.GetData(DataFormats.FileDrop, false));
            }
            catch { }
        }

        private void lbImagens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AbrirImagem();
            else if (e.KeyCode == Keys.Escape)
                Close();
            else
            {
                try
                {
                    if (e.KeyData == Keys.Delete)
                    {
                        int posicao = lbImagens.SelectedIndex;
                        lbImagens.ClearSelected();
                        pictureBox1.ImageLocation = "";
                        lbImagens.Items.Remove(lbImagens.Items[posicao]);
                        string[] temp = new string[arrayimagens.Length - 1];
                        int varInt = 0;
                        for (int n = 0; n < arrayimagens.Length; n++)
                            if (n != posicao)
                            {
                                Array.Copy(arrayimagens, n, temp, varInt, 1);
                                varInt++;
                            }
                        arrayimagens = temp;
                    }
                }
                catch { }
            }
        }

        private void lbImagens_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lbImagens.SelectedIndex;
            if (lbImagens.SelectedIndex >= 0)
                pictureBox1.ImageLocation = arrayimagens[lbImagens.SelectedIndex]; 
        }

        private void lbImagens_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            index = lbImagens.SelectedIndex;
            alterartimer();
        }
        
        private void alterartimer()
        {
            btnComeçar.Text = (timer1.Enabled) ? ("Parar") : ("Começar");
        }

        private void lbImagens_DoubleClick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            alterartimer();
        }
        
        void AtualizarLista()
        {
            lbImagens.Items.Clear();
            foreach (string foto in arrayimagens)
                lbImagens.Items.Add(foto.Substring(foto.LastIndexOf('\\') + 1));
        }
        
        void AdicionarImagens(string[] arquivos)
        {
            if (arrayimagens == null)
                arrayimagens = arquivos;
            else
            {
                string[] temp, tempPossiveis = new string[arquivos.Length];
                int varInt = 0;
                foreach (string varString in arquivos)
                    if (!arrayimagens.Contains<string>(varString))
                    {
                        tempPossiveis[varInt] = varString;
                        varInt++;
                    }
                if (varInt > 0)
                {
                    temp = new string[arrayimagens.Length + varInt];
                    Array.Copy(arrayimagens, temp, arrayimagens.Length);
                    Array.Copy(tempPossiveis, 0, temp, arrayimagens.Length, tempPossiveis.Length);
                    arrayimagens = temp;
                }
            }
            AtualizarLista();
        }

        void AbrirImagem()
        {
            frmImagem imagem = new frmImagem();
            if (imagem.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = arrayimagens[index];
                lbImagens.SelectedIndex = index;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (Width > 300)
            {
                //Height=1046;
                lbImagens.Width = 200;
                lbImagens.Height = Height-110;
                pictureBox1.Left = 218;
            }
            else
            {
                //Height=300;
                lbImagens.Width = 120;
                lbImagens.Height = Height-110;
                pictureBox1.Left = 138;
            }
        }
    }
}
