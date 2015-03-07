using System;
using System.Windows.Forms;
using System.Drawing;

namespace Slides
{
    public partial class frmImagem : Form
    {
        public frmImagem()
        {
            InitializeComponent();
        }
        //http://www.codeproject.com/Articles/26465/Simple-auto-hide-panel
        private void frmImagem_Load(object sender, EventArgs e)
        {
            timer1.Interval = frmConfiguracao.timer;
            BackColor = frmConfiguracao.cor;
            MudarImagem();
        }

        void MudarImagem()
        {
            timer1.Enabled = false;
            BackgroundImage = Image.FromFile(Form1.arrayimagens[Form1.index]);
            lblNome.Text = Form1.arrayimagens[Form1.index].Substring(0, Form1.arrayimagens[Form1.index].LastIndexOf('\\') + 1) + "\n" + Form1.arrayimagens[Form1.index].Substring(Form1.arrayimagens[Form1.index].LastIndexOf('\\') + 1);
        }

        void Proxima()
        {
            Form1.index = (Form1.index == Form1.arrayimagens.Length - 1) ? (0) : (Form1.index + 1);
            MudarImagem();
        }
        void Anterior()
        {
            Form1.index = (Form1.index == 0) ? (Form1.arrayimagens.Length - 1) : (Form1.index - 1);
            MudarImagem();
        }
        
        private void frmImagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left||e.KeyCode==Keys.Up)
                Anterior();
            else if (e.KeyCode == Keys.Right||e.KeyCode==Keys.Down)
                Proxima();
            else if (e.KeyCode == Keys.Escape||e.KeyCode==Keys.Enter)
                DialogResult = DialogResult.OK;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Proxima();
            timer1.Enabled = true;
        }

        private void frmImagem_DoubleClick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void frmImagem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                Anterior();
            else if (e.Button == MouseButtons.Left)
                Proxima();
        }

        private void frmImagem_MouseMove(object sender, MouseEventArgs e)
        {
            lblNome.Visible = (e.Y >= this.Height - 50) ? (true) : (false);
            lblAnterior.Visible = (e.X <= lblProxima.Width * 2) ? (true) : (false);//btnAnterior.Visible = (e.X <= btnAnterior.Width * 2) ? (true) : (false); 
            lblProxima.Visible = (e.X >= this.Width - lblAnterior.Width * 2) ? (true) : (false);//btnProxima.Visible = (e.X >= this.Width - btnProxima.Width * 2) ? (true) : (false);
        }

        private void lblProxima_Click(object sender, EventArgs e)//private void btnProxima_Click(object sender, EventArgs e)
        {
            Proxima();
        }

        private void lblAnterior_Click(object sender, EventArgs e)//private void btnAnterior_Click(object sender, EventArgs e)
        {
            Anterior();
        }
    }
}
