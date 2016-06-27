using System;
using System.Windows.Forms;

namespace CalculosGemas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AtualizaVisibleGeral();
        }
        /*Fontes:
        http://gaming.stackexchange.com/questions/196624/how-are-the-gem-values-worked-out
        http://steamcommunity.com/market/listings/753/753-Sack%20of%20Gems
        http://steamtradingcards.wikia.com/wiki/Gems_by_Game

        Assuming that:
              n = # cards in set
            , c = value of single card
            , g = value of emoticon/background
            , and b = gems to craft booster
        , any one of the four can be calculated if any two other values are known.
        This doesn't hold true for every game, but is accurate for the vast majority:

        n = 6000/b
        n = 2g/c
        c = bg/3000
        c = 2g/n
        g = 3000c/b
        g = n * c/2
        b = 6000/n
        b = 3000c/g
        
        */
        uint n, c, g, b;
        bool escolhaautomatica = false;
        enum OPCOES_CALCULO { N_1, N_2, C_1, C_2, G_1, G_2, B_1, B_2 }
        OPCOES_CALCULO opcao_atual;
        #region Calculos
        const uint _3000 = 3000, _2 = 2;
        uint Formula(uint n1, uint n2, uint n3)
        {
            return (uint)Math.Round((double)n1 * n2 / n3);
        }
        void CalculoN_1()
        {
            n = Formula(_3000, _2, b);
        }
        void CalculoN_2()
        {
            n = Formula(_2, g, c);
        }
        void CalculoC_1()
        {
            c = Formula(b, g, _3000);
        }
        void CalculoC_2()
        {
            c = Formula(_2, g, n);
        }

        void CalculoG_1()
        {
            g = Formula(_3000, c, b);
        }
        void CalculoG_2()
        {
            g = Formula(n, c, _2);
        }

        void CalculoB_1()
        {
            b = Formula(_3000, _2, n);
        }

        void CalculoB_2()
        {
            b = Formula(_3000, c, g);
        }
        #endregion

        #region Logicas da Tela
        void _AtualizaInformacoesVariavel(uint variavel, TextBox txt)
        {
            if (variavel > 0)
                txt.Text = variavel.ToString();
            else
                txt.ResetText();
        }

        void AtualizaInformacoesGerais()
        {
            _AtualizaInformacoesVariavel(n, txtN);
            _AtualizaInformacoesVariavel(c, txtC);
            _AtualizaInformacoesVariavel(g, txtG);
            _AtualizaInformacoesVariavel(b, txtB);
        }

        void SetUtilidadeTextBox(TextBox txt, bool valor)
        {
            txt.TabStop = valor;
            txt.ReadOnly = !valor;
        }

        void AtualizaVisibleGeral()
        {
            if (escolhaautomatica)
            {
                SetUtilidadeTextBox(txtN, true);
                SetUtilidadeTextBox(txtC, true);
                SetUtilidadeTextBox(txtG, true);
                SetUtilidadeTextBox(txtB, true);
            }
            else
            {
                switch (opcao_atual)
                {
                    case OPCOES_CALCULO.N_1:
                        SetUtilidadeTextBox(txtN, false);
                        SetUtilidadeTextBox(txtC, false);
                        SetUtilidadeTextBox(txtG, false);
                        SetUtilidadeTextBox(txtB, true);
                        break;
                    case OPCOES_CALCULO.N_2:
                        SetUtilidadeTextBox(txtN, false);
                        SetUtilidadeTextBox(txtC, true);
                        SetUtilidadeTextBox(txtG, true);
                        SetUtilidadeTextBox(txtB, false);
                        break;
                    case OPCOES_CALCULO.C_1:
                        SetUtilidadeTextBox(txtN, false);
                        SetUtilidadeTextBox(txtC, false);
                        SetUtilidadeTextBox(txtG, true);
                        SetUtilidadeTextBox(txtB, true);
                        break;
                    case OPCOES_CALCULO.C_2:
                        SetUtilidadeTextBox(txtN, true);
                        SetUtilidadeTextBox(txtC, false);
                        SetUtilidadeTextBox(txtG, true);
                        SetUtilidadeTextBox(txtB, false);
                        break;
                    case OPCOES_CALCULO.G_1:
                        SetUtilidadeTextBox(txtN, false);
                        SetUtilidadeTextBox(txtC, true);
                        SetUtilidadeTextBox(txtG, false);
                        SetUtilidadeTextBox(txtB, true);
                        break;
                    case OPCOES_CALCULO.G_2:
                        SetUtilidadeTextBox(txtN, true);
                        SetUtilidadeTextBox(txtC, true);
                        SetUtilidadeTextBox(txtG, false);
                        SetUtilidadeTextBox(txtB, false);
                        break;
                    case OPCOES_CALCULO.B_1:
                        SetUtilidadeTextBox(txtN, true);
                        SetUtilidadeTextBox(txtC, false);
                        SetUtilidadeTextBox(txtG, false);
                        SetUtilidadeTextBox(txtB, false);
                        break;
                    case OPCOES_CALCULO.B_2:
                        SetUtilidadeTextBox(txtN, false);
                        SetUtilidadeTextBox(txtC, true);
                        SetUtilidadeTextBox(txtG, true);
                        SetUtilidadeTextBox(txtB, false);
                        break;
                    default:
                        SetUtilidadeTextBox(txtN, false);
                        SetUtilidadeTextBox(txtC, false);
                        SetUtilidadeTextBox(txtG, false);
                        SetUtilidadeTextBox(txtB, false);
                        break;
                }
            }
        }

        void _AtribuiValorVariavel(ref uint variavel, TextBox txt)
        {
            if (String.IsNullOrWhiteSpace(txt.Text))
                variavel = 0;
            else
                variavel = Convert.ToUInt16(txt.Text);
        }

        void AtribuirValorGeral()
        {
            _AtribuiValorVariavel(ref n, txtN);
            _AtribuiValorVariavel(ref c, txtC);
            _AtribuiValorVariavel(ref g, txtG);
            _AtribuiValorVariavel(ref b, txtB);
        }
        void TrocaModoDeEscolha()
        {
            if (escolhaautomatica)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
            AtualizaVisibleGeral();
        }
        #endregion

        #region Eventos
        private void rbEscolhaManual_CheckedChanged(object sender, EventArgs e)
        {
            escolhaautomatica = rbEscolhaAutomatica.Checked;
            TrocaModoDeEscolha();
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void rbN1_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                opcao_atual = (OPCOES_CALCULO)Convert.ToInt16((sender as RadioButton).Tag);
                AtualizaVisibleGeral();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool sucesso = true;
            try
            {
                AtribuirValorGeral();
            }
            catch (Exception)
            {
                sucesso = false;
            }
            if (!sucesso)
                return;
            if (!escolhaautomatica)
            {
                switch (opcao_atual)
                {
                    case OPCOES_CALCULO.N_1:
                        CalculoN_1();
                        txtQtd.Text = n.ToString();
                        break;
                    case OPCOES_CALCULO.N_2:
                        CalculoN_2();
                        txtQtd.Text = n.ToString();
                        break;
                    case OPCOES_CALCULO.C_1:
                        CalculoC_1();
                        txtQtd.Text = c.ToString();
                        break;
                    case OPCOES_CALCULO.C_2:
                        CalculoC_2();
                        txtQtd.Text = c.ToString();
                        break;
                    case OPCOES_CALCULO.G_1:
                        CalculoG_1();
                        txtQtd.Text = g.ToString();
                        break;
                    case OPCOES_CALCULO.G_2:
                        CalculoG_2();
                        txtQtd.Text = g.ToString();
                        break;
                    case OPCOES_CALCULO.B_1:
                        CalculoB_1();
                        txtQtd.Text = b.ToString();
                        break;
                    case OPCOES_CALCULO.B_2:
                        CalculoB_2();
                        txtQtd.Text = b.ToString();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                if (n > 0 && b == 0)
                    CalculoB_1();
                else if (b > 0 && n == 0)
                    CalculoN_1();
                if (n == 0)
                    CalculoN_2();
                if (c == 0)
                {
                    CalculoC_1();
                    CalculoC_2();
                }
                if (g == 0)
                {
                    CalculoG_1();
                    CalculoG_2();
                }
                if (b == 0)
                    CalculoB_2();
            }
            AtualizaInformacoesGerais();
        }

        private void btn_Gema_Click(object sender, EventArgs e)
        {
            uint qtd=0;
            float preco = 0;
            bool sucesso = true;
            try
            {
                AtribuirValorGeral();
                qtd = Convert.ToUInt16(txtQtd.Text);
                preco = Convert.ToSingle(txt_Gema.Text);
            }
            catch (Exception)
            {
                sucesso = false;
            }
            if (!sucesso)
            {
                txt_Gema.ResetText();
                return;
            }
            lbl_Gema.Text = $"{(Math.Round(preco / qtd, 5) * 1000)}$/1000 gemas";
        }
        #endregion
    }
}
