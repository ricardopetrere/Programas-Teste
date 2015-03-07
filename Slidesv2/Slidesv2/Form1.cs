using System;
using System.Windows.Forms;

namespace Slidesv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static bool configurar = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmImagem imagem = new frmImagem();
            try
            {
                timer1.Enabled = false;
                alterartimer();
                imagem.imagem = pictureBox1.ImageLocation;
                imagem.Show();
            }
            catch { }
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            configurar = !configurar;
            if (configurar)
            {
                panConfigurar.Visible = true;
                panConfigurar.Height = 73;
                panImagens.Top = 119;
            }
            else
                esconderconfigurar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            esconderconfigurar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                txtTimer.Text = txtTimer.Text.Replace(',', '.');
                timer1.Interval = Convert.ToInt16(Convert.ToDouble(txtTimer.Text) * 1000);
                alterartimer();
                foreach (string foto in openFileDialog1.SafeFileNames)
                    if (!lbImagens.Items.Contains(foto))
                        lbImagens.Items.Add(foto);
                esconderconfigurar();
            }
            catch
            {
                MessageBox.Show("Preencha corretamente.");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            lbImagens.ClearSelected();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string url = openFileDialog1.FileNames[0].Remove(openFileDialog1.FileNames[0].LastIndexOf('\\') + 1);
                if (url != txtPasta.Text)
                {
                    for (int n = 0; n < lbImagens.Items.Count; n++)
                    {
                        if (!lbImagens.Items[n].ToString().Contains(@":\"))
                            lbImagens.Items[n] = txtPasta.Text + lbImagens.Items[n].ToString();
                        if (lbImagens.Items[n].ToString().Contains(url))
                            lbImagens.Items[n] = lbImagens.Items[n].ToString().Substring(lbImagens.Items[n].ToString().LastIndexOf('\\') + 1);
                    }
                    txtPasta.Text = openFileDialog1.FileNames[0].Remove(openFileDialog1.FileNames[0].LastIndexOf('\\') + 1);
                }
            }
        }

        private void lbImagens_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.ImageLocation = (lbImagens.SelectedItem.ToString().Contains(@":\")) ? (lbImagens.SelectedItem.ToString()) : (txtPasta.Text + lbImagens.SelectedItem.ToString());
            }
            catch { }
        }
        private void esconderconfigurar()
        {
            configurar = false;
            panConfigurar.Height = 1;
            panConfigurar.Visible = false;
            panImagens.Top = 41;
        }

        private void btnComeçar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            alterartimer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbImagens.SelectedIndex = (lbImagens.SelectedIndex == lbImagens.Items.Count - 1) ? (0) : (lbImagens.SelectedIndex + 1);
        }
        private void alterartimer()
        {
            btnComeçar.Text = (timer1.Enabled) ? ("Parar") : ("Começar");
        }

        private void lbImagens_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            alterartimer();
        }

        private void lbImagens_DoubleClick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            alterartimer();
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
                string[] arquivos = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                foreach (string imagem in arquivos)
                    if (!lbImagens.Items.Contains(imagem))
                        lbImagens.Items.Add(imagem);
            }
            catch { }
        }

        private void lbImagens_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Delete)
                {
                    int index = lbImagens.SelectedIndex;
                    lbImagens.ClearSelected();
                    pictureBox1.ImageLocation = "";
                    lbImagens.Items.Remove(lbImagens.Items[index]);
                }
            }
            catch { }
        }
    }
}
