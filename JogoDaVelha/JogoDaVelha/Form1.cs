using System;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool jogador1=true;
        int usado = 0;
        bool completo;
        public void checar()
        {
            lblEnunciado.Text = (jogador1) ? ("Vez de jogar: Jogador 1") : ("Vez de jogar: Jogador 2");
            if (btn00.Text == btn01.Text && btn01.Text == btn02.Text && btn00.Text.Length > 0)
                completo = true;
            else if (btn10.Text == btn11.Text && btn11.Text == btn12.Text && btn10.Text.Length > 0)
                completo = true;
            else if (btn20.Text == btn21.Text && btn21.Text == btn22.Text && btn20.Text.Length > 0)
                completo = true;
            else if (btn00.Text == btn10.Text && btn10.Text == btn20.Text && btn00.Text.Length > 0)
                completo = true;
            else if (btn01.Text == btn11.Text && btn11.Text == btn21.Text && btn01.Text.Length > 0)
                completo = true;
            else if (btn02.Text == btn12.Text && btn12.Text == btn22.Text && btn02.Text.Length > 0)
                completo = true;
            else if (btn02.Text == btn11.Text && btn11.Text == btn20.Text && btn02.Text.Length > 0)
                completo = true;
            else if (btn00.Text == btn11.Text && btn11.Text == btn22.Text && btn00.Text.Length > 0)
                completo = true;
            if (completo)
            {
                lblEnunciado.Text = (!jogador1) ? ("Vitória do jogador 1") : ("Vitória do jogador 2");
                panBotoes.Enabled = false;
            }
            else if (usado == 9)
                lblEnunciado.Text = "Empate!";
        }
        private void btn00_Click(object sender, EventArgs e)
        {
            mudarbotao(btn00);
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            mudarbotao(btn01);
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            mudarbotao(btn02);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            mudarbotao(btn10);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            mudarbotao(btn11);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            mudarbotao(btn12);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            mudarbotao(btn20);
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            mudarbotao(btn21);
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            mudarbotao(btn22);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            panBotoes.Enabled = true;
            jogador1 = true;
            completo = false;
            usado = 0;
            lblEnunciado.Text = "Vez de jogar: Jogador 1";
            resetarbotao(btn00);
            resetarbotao(btn01);
            resetarbotao(btn02);
            resetarbotao(btn10);
            resetarbotao(btn11);
            resetarbotao(btn12);
            resetarbotao(btn20);
            resetarbotao(btn21);
            resetarbotao(btn22);
        }
        private void resetarbotao(Button botao)
        {
            botao.ResetText();
            botao.Enabled = true;
        }
        private void mudarbotao(Button botao)
        {
            botao.Text = (jogador1) ? ("X") : ("O");
            jogador1 = !jogador1;
            botao.Enabled = false;
            usado++;
            checar();
        }
    }
}
