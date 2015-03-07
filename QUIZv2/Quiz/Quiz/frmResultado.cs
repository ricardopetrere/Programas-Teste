using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz
{
    public partial class frmResultado : Form
    {
        public frmResultado()
        {
            InitializeComponent();
        }
        public struct Questao
        {
            public string pergunta;
            public string tema;
            public string resppc;
            public string alta, altb, altc, altd;
            public string respuser;
            public bool sorteado;
        }
        public frmQuiz Quiz = new frmQuiz();
        static int acertos=0;
        public frmQuiz.Questao[] colaQuiz = frmQuiz.copiaQuiz;
        private void checaracertos()
        {
            for (int n = 0; n < colaQuiz.Length; n++)
                if (colaQuiz[n].resppc == colaQuiz[n].respuser)
                    acertos++;
        }
        private void cbEscolherPergunta_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPergunta.Text = colaQuiz[cbEscolherPergunta.SelectedIndex].pergunta;
            lblRespostaUser.Text = colaQuiz[cbEscolherPergunta.SelectedIndex].respuser;
            lblRespostaPc.Text = colaQuiz[cbEscolherPergunta.SelectedIndex].resppc;
        }
        private void frmResultado_Load(object sender, EventArgs e)
        {
            checaracertos();
            cbEscolherPergunta.Items.Clear();
            for (int n = 0; n < colaQuiz.Length; n++)
                cbEscolherPergunta.Items.Add("Pergunta "+(n+1).ToString());
            lblNumAcertos.Text = acertos.ToString();
            lblNumErros.Text = (colaQuiz.Length - acertos).ToString();
            lblTotal.Text = colaQuiz.Length.ToString();
            cbEscolherPergunta.SelectedIndex = 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        
    }
}
