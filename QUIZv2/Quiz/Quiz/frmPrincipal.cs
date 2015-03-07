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
    public partial class frmPrincipal : Form
    {
        const string arquivo = @"quiz.txt";
        public string[] linhas = File.ReadAllLines(arquivo, Encoding.UTF8);
        Tema[] temas = new Tema[10];
        

        public struct Tema
        {
            public string tema;
            public int qtdequestoes;
        }
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            if (cbQtdeQuestoes.SelectedIndex<0)
                MessageBox.Show("Selecione uma quantidade de questões.", "Erro!");
            else
            {
                
                frmQuiz quiz = new frmQuiz();
                quiz.tema=cbTemas.SelectedItem.ToString();
                quiz.total=cbQtdeQuestoes.Items.Count;
                quiz.qtde = cbQtdeQuestoes.SelectedIndex + 1;
                quiz.Show();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (File.Exists(arquivo))
            {
                int temalistados = 0;
                for (int n = 0; n < linhas.Length; n++)
                {
                    bool existetema = false;
                    string[] dados = linhas[n].Split('|');
                    for (int a = 0; a < temalistados; a++)
                        if (dados[1].Trim() == temas[a].tema)
                        {
                            temas[a].qtdequestoes++;
                            existetema = true;
                        }
                    if (!existetema)
                    {
                        temas[temalistados].tema = dados[1].Trim();
                        cbTemas.Items.Add(temas[temalistados].tema);
                        temas[temalistados].qtdequestoes = 1;
                        temalistados++;
                    }
                }

            }
            else
                lblCarregou.Text = "Não foi encontrado o arquivo .txt";
        }

        private void cbTemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbQtdeQuestoes.Items.Clear();
            for (int n = 0; n < temas[cbTemas.SelectedIndex].qtdequestoes; n++)
                cbQtdeQuestoes.Items.Add(n + 1);
        }

    }
}
