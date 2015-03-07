using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Quiz
{
    public partial class frmQuiz : Form
    {
        public frmQuiz()
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
        public int total, qtde;
        public string tema;
        static int total2, qtde2;
        static string tema2;
        frmPrincipal form1 = new frmPrincipal();
        static Questao[] alternativas;
        public Questao[] quiz=new Questao[qtde2];
        Random sorteio = new Random();
        int usada = 0;
        public static Questao[] copiaQuiz;
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbA.Checked)
                    quiz[usada].respuser = quiz[usada].alta;
                else if (rbB.Checked)
                    quiz[usada].respuser = quiz[usada].altb;
                else if (rbC.Checked)
                    quiz[usada].respuser = quiz[usada].altc;
                else if (rbD.Checked)
                    quiz[usada].respuser = quiz[usada].altd;


                copiaQuiz = quiz;

                if (quiz[usada].respuser.Length > 0)
                {
                    usada++;
                    if (usada < qtde2)
                    {
                        rbA.Checked = false;
                        rbB.Checked = false;
                        rbC.Checked = false;
                        rbD.Checked = false;
                        perguntas(usada);
                    }
                    else
                    {
                        frmResultado resultado = new frmResultado();
                        resultado.Show();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Selecione uma das alternativas.");
            }
        }
        private void perguntas(int index)
        {
            while (true)
            {
                int questao = sorteio.Next(total);
                if (alternativas[questao].sorteado == false)
                {
                    quiz[index].pergunta = alternativas[questao].pergunta;
                    quiz[index].tema = alternativas[questao].tema;
                    quiz[index].resppc = alternativas[questao].resppc;
                    quiz[index].alta = alternativas[questao].alta;
                    quiz[index].altb = alternativas[questao].altb;
                    quiz[index].altc = alternativas[questao].altc;
                    quiz[index].altd = alternativas[questao].altd;
                    lblPergunta.Text = quiz[index].pergunta;
                    rbA.Text = quiz[index].alta;
                    rbB.Text = quiz[index].altb;
                    rbC.Text = quiz[index].altc;
                    rbD.Text = quiz[index].altd;
                    this.Text = "Pergunta " + (index + 1);
                    alternativas[questao].sorteado = true;
                    break;
                }
            }
        }
        private void darvalor()
        {
            total2 = total;
            tema2 = tema;
            qtde2 = qtde;
        }
        private void frmQuiz_Load(object sender, EventArgs e)
        {
            darvalor();
            alternativas = new Questao[total2];
            quiz = new Questao[qtde2];
            int lida = 0;
            for (int n = 0; n < form1.linhas.Length; n++)
                if (form1.linhas[n].IndexOf(tema2) > 0)
                {
                    string[] dados = form1.linhas[n].Split('|');
                    alternativas[lida].pergunta = dados[0].Trim();
                    alternativas[lida].tema = dados[1].Trim();
                    alternativas[lida].resppc = dados[2].Trim();
                    alternativas[lida].alta = dados[3].Trim();
                    alternativas[lida].altb = dados[4].Trim();
                    alternativas[lida].altc = dados[5].Trim();
                    alternativas[lida].altd = dados[6].Trim();
                    lida++;
                }
            perguntas(0);

        }
        
    }
}
