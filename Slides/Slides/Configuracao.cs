using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Slides
{
    public partial class frmConfiguracao : Form
    {
        public frmConfiguracao()
        {
            InitializeComponent();
        }
        public static int timer = 1000;
        public static string[] imagens;
        public static Color cor = Color.Black;
        /*private void frmConfiguracao_Load(object sender, EventArgs e)
        {
            //openFileDialog1.Multiselect = true;
            //openFileDialog1.Filter = "Arquivos de Imagens|*.png;*.jpg;*.jpeg;*.bmp" ;
            //colocar ; nas extensões permite mais de uma extensão por definição
        }*/

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                txtTimer.Text = txtTimer.Text.Replace('.', ',');
                timer = Convert.ToInt16((Convert.ToDouble(txtTimer.Text)) * 1000);
                DialogResult = DialogResult.OK;
            }
            catch (FormatException)
            {
                MessageBox.Show("Escolha um intervalo de tempo válido");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            /*if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagens = openFileDialog1.SafeFileNames;//vetor com apenas os nomes de todas as imagens selecionadas (necessário .Multiselect=true)
                txtPasta.Text = openFileDialog1.FileNames[0].Remove(openFileDialog1.FileNames[0].LastIndexOf('\\'));
            }*/
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPasta.Text = folderBrowserDialog1.SelectedPath;
                string[] part1 = null, part2 = null, part3 = null, part4 = null;
                part1 = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.jpg");
                part2 = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.jpeg");
                part3 = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.bmp");
                part4 = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.png");
                imagens = new string[part1.Length + part2.Length + part3.Length + part4.Length];
                Array.Copy(part1, 0, imagens, 0, part1.Length);
                Array.Copy(part2, 0, imagens, part1.Length, part2.Length);
                Array.Copy(part3, 0, imagens, part1.Length + part2.Length, part3.Length);
                Array.Copy(part4, 0, imagens, part1.Length + part2.Length + part3.Length, part4.Length);
            }
            /*
                para usar com folderBrowserDialog: (e System.IO)
                http://www.codeproject.com/Articles/23082/A-Simple-Image-Slide-Show
            */
            
        }
        
        private void txtTimer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oem3)//a tecla '
                if (txtTimer.Text == "ShowColorDialog")
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    {
                        cor = colorDialog1.Color;
                        txtTimer.Text = "1";
                    }
        }
    }
}
