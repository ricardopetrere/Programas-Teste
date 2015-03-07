using System;
using System.Windows.Forms;

namespace Slidesv2
{
    public partial class frmImagem : Form
    {
        public frmImagem()
        {
            InitializeComponent();
        }
        public string imagem;
        
        private void frmImagem_Load(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = imagem;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
