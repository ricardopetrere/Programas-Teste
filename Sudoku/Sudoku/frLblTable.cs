using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Sudoku
{
    public partial class frLblTable : Form
    {
        public frLblTable()
        {
            InitializeComponent();
        }
        string referencia;
        int Tempo, Mapa_Selecionado = 0;
        Label Selecionado;
        Label[] Quadradinhos = new Label[81];
        const string Pasta = @"mapas";
        public static string[] Arquivos;
        public static string[] Mapa;
        public string[] Slots;
        bool Jogando = false;

        private void btnComecar_Click(object sender, EventArgs e)
        {
            Jogando = true;
            panConfiguracoes.Visible = false;
            timer1.Enabled = !timer1.Enabled;
            btnComecar.Text = (timer1.Enabled) ? ("Pausar") : ("Continuar");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tempo++;
            TimeSpan diferenca = TimeSpan.FromSeconds(Tempo);
            txtTimer.Text = (diferenca.Hours != 0) ? (diferenca.Hours.ToString() + ":" + diferenca.Minutes.ToString("00") + ":" +
                diferenca.Seconds.ToString("00")) : (diferenca.Minutes.ToString("00") + ":" + diferenca.Seconds.ToString("00"));
        }

        private void frLblTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            //(salvar progresso caso saia com mapa incompleto exemplo: jogo*.rec)
            if (Jogando)
            {
                timer1.Enabled = false;
                btnComecar.Text = "Continuar";
                DialogResult sair = MessageBox.Show("Deseja salvar o progresso no mapa?", "",MessageBoxButtons.YesNoCancel);
                switch (sair)
                {
                    case DialogResult.Yes:
                            frSalvar salvar = new frSalvar();
                            if (salvar.ShowDialog() == DialogResult.OK)
                            {
                                string partes = "";
                                for (int n = 0; n < 81; n++)
                                {
                                    if (Quadradinhos[n].Enabled == false)
                                        partes += "&" + Quadradinhos[n].Text;
                                    else if (Quadradinhos[n].Text == "")
                                        partes += Slots[n];
                                    else
                                        partes += Slots[n][0].ToString() + "#" + Quadradinhos[n].Text;
                                    partes += (n == 80) ? "|" : " ";
                                }
                                partes += "Não " + lblDificuldade.Text.Trim().Split(' ')[1] + " "+Tempo.ToString() + " "+lblDescricao.Text;
                                File.WriteAllText(salvar.nome, partes,Encoding.UTF8);
                            }
                            break;
                    case DialogResult.No:
                            DialogResult = DialogResult.OK;
                            return;
                    case DialogResult.Cancel:
                            e.Cancel = true;
                            break;
                }
            }
        }

        private void frLblTable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
                return;
            if (Selecionado != null && (int)e.KeyChar < 58 && (int)e.KeyChar > 47)
                AtribuirLabel(e.KeyChar);
            else if (e.KeyChar == '\'')
            {
                /*frEditor editor=new frEditor();
                if (editor.ShowDialog() == DialogResult.OK)
                {
                }*/
            }
        }

        private void lbl1_1_Click(object sender, EventArgs e)
        {
            if (Selecionado != null)
                Selecionado.BackColor = Color.White;
            (sender as Label).BackColor = Color.Yellow;
            Selecionado = sender as Label;
            AtribuirBotoes(true);
        }

        private void lbl1_1_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        private void frLblTable_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (Selecionado != null)
                Selecionado.BackColor = Color.White;
            AtribuirBotoes(false);
            Selecionado = null;
        }

        private void lbl1_1_TextChanged(object sender, EventArgs e)
        {
            Label temp = sender as Label;
            if (temp.Text.Contains('&'))
            {
                temp.Text = temp.Text.Remove(0, 1);
                temp.Enabled = false;
                temp.TextAlign = ContentAlignment.MiddleCenter;
            }
            else if (temp.Text.Contains('#'))
            {
                temp.Text = temp.Text.Remove(0, 2);
                temp.Enabled = true;
                temp.TextAlign = (temp.Text.Length == 1) ? (ContentAlignment.MiddleCenter) : (ContentAlignment.TopLeft);
            }
            else if (Selecionado != null)
            {
                Selecionado.TextAlign = (Selecionado.Text.Length == 1) ? (ContentAlignment.MiddleCenter) : (ContentAlignment.TopLeft);
                Concluido();
            }
        }

        void AtribuirLabel(char numero)
        {
            if (Selecionado.Text.Contains(numero))
                Selecionado.Text = Selecionado.Text.Remove(Selecionado.Text.IndexOf(numero), 1);
            else
            {
                int varInt = Selecionado.Text.Length;
                foreach (char varChar in Selecionado.Text)
                    if ((int)varChar > (int)numero)
                    {
                        varInt = Selecionado.Text.IndexOf(varChar);
                        break;
                    }
                Selecionado.Text = Selecionado.Text.Insert(varInt, numero.ToString());
            }
            AtribuirBotoes(panOpcoes.Enabled);
        }

        void AtribuirBotoes(bool ativado)
        {
            panOpcoes.Enabled = ativado;
            button1.BackColor = (ativado) ? ((Selecionado.Text.Contains('1')) ? (Color.Yellow) : (SystemColors.Control)) : (SystemColors.Control);
            button2.BackColor = (ativado) ? ((Selecionado.Text.Contains('2')) ? (Color.Yellow) : (SystemColors.Control)) : (SystemColors.Control);
            button3.BackColor = (ativado) ? ((Selecionado.Text.Contains('3')) ? (Color.Yellow) : (SystemColors.Control)) : (SystemColors.Control);
            button4.BackColor = (ativado) ? ((Selecionado.Text.Contains('4')) ? (Color.Yellow) : (SystemColors.Control)) : (SystemColors.Control);
            button5.BackColor = (ativado) ? ((Selecionado.Text.Contains('5')) ? (Color.Yellow) : (SystemColors.Control)) : (SystemColors.Control);
            button6.BackColor = (ativado) ? ((Selecionado.Text.Contains('6')) ? (Color.Yellow) : (SystemColors.Control)) : (SystemColors.Control);
            button7.BackColor = (ativado) ? ((Selecionado.Text.Contains('7')) ? (Color.Yellow) : (SystemColors.Control)) : (SystemColors.Control);
            button8.BackColor = (ativado) ? ((Selecionado.Text.Contains('8')) ? (Color.Yellow) : (SystemColors.Control)) : (SystemColors.Control);
            button9.BackColor = (ativado) ? ((Selecionado.Text.Contains('9')) ? (Color.Yellow) : (SystemColors.Control)) : (SystemColors.Control);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                AtribuirLabel((sender as Button).Name[6]);
        }

        private void frLblTable_Load(object sender, EventArgs e)
        {//referencia TODOS os Labels do mapa
            Quadradinhos[0] = lbl1_1; Quadradinhos[1] = lbl1_2; Quadradinhos[2] = lbl1_3; Quadradinhos[3] = lbl1_4; Quadradinhos[4] = lbl1_5; Quadradinhos[5] = lbl1_6; Quadradinhos[6] = lbl1_7; Quadradinhos[7] = lbl1_8; Quadradinhos[8] = lbl1_9;
            Quadradinhos[9] = lbl2_1; Quadradinhos[10] = lbl2_2; Quadradinhos[11] = lbl2_3; Quadradinhos[12] = lbl2_4; Quadradinhos[13] = lbl2_5; Quadradinhos[14] = lbl2_6; Quadradinhos[15] = lbl2_7; Quadradinhos[16] = lbl2_8; Quadradinhos[17] = lbl2_9;
            Quadradinhos[18] = lbl3_1; Quadradinhos[19] = lbl3_2; Quadradinhos[20] = lbl3_3; Quadradinhos[21] = lbl3_4; Quadradinhos[22] = lbl3_5; Quadradinhos[23] = lbl3_6; Quadradinhos[24] = lbl3_7; Quadradinhos[25] = lbl3_8; Quadradinhos[26] = lbl3_9;
            Quadradinhos[27] = lbl4_1; Quadradinhos[28] = lbl4_2; Quadradinhos[29] = lbl4_3; Quadradinhos[30] = lbl4_4; Quadradinhos[31] = lbl4_5; Quadradinhos[32] = lbl4_6; Quadradinhos[33] = lbl4_7; Quadradinhos[34] = lbl4_8; Quadradinhos[35] = lbl4_9;
            Quadradinhos[36] = lbl5_1; Quadradinhos[37] = lbl5_2; Quadradinhos[38] = lbl5_3; Quadradinhos[39] = lbl5_4; Quadradinhos[40] = lbl5_5; Quadradinhos[41] = lbl5_6; Quadradinhos[42] = lbl5_7; Quadradinhos[43] = lbl5_8; Quadradinhos[44] = lbl5_9;
            Quadradinhos[45] = lbl6_1; Quadradinhos[46] = lbl6_2; Quadradinhos[47] = lbl6_3; Quadradinhos[48] = lbl6_4; Quadradinhos[49] = lbl6_5; Quadradinhos[50] = lbl6_6; Quadradinhos[51] = lbl6_7; Quadradinhos[52] = lbl6_8; Quadradinhos[53] = lbl6_9;
            Quadradinhos[54] = lbl7_1; Quadradinhos[55] = lbl7_2; Quadradinhos[56] = lbl7_3; Quadradinhos[57] = lbl7_4; Quadradinhos[58] = lbl7_5; Quadradinhos[59] = lbl7_6; Quadradinhos[60] = lbl7_7; Quadradinhos[61] = lbl7_8; Quadradinhos[62] = lbl7_9;
            Quadradinhos[63] = lbl8_1; Quadradinhos[64] = lbl8_2; Quadradinhos[65] = lbl8_3; Quadradinhos[66] = lbl8_4; Quadradinhos[67] = lbl8_5; Quadradinhos[68] = lbl8_6; Quadradinhos[69] = lbl8_7; Quadradinhos[70] = lbl8_8; Quadradinhos[71] = lbl8_9;
            Quadradinhos[72] = lbl9_1; Quadradinhos[73] = lbl9_2; Quadradinhos[74] = lbl9_3; Quadradinhos[75] = lbl9_4; Quadradinhos[76] = lbl9_5; Quadradinhos[77] = lbl9_6; Quadradinhos[78] = lbl9_7; Quadradinhos[79] = lbl9_8; Quadradinhos[80] = lbl9_9;
            try { AtribuirMapa(); }
            catch { MessageBox.Show("Não há mapas salvos!"); Close(); }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            frLblTable_MouseCaptureChanged(sender, e);
            Tempo = 0;
            txtTimer.Clear();
            btnComecar.Enabled = true;
            Mapa_Selecionado = ((sender as Button).Name != "btnAnterior") ? (++Mapa_Selecionado) : (--Mapa_Selecionado);
            AtribuirMapa();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            panConfiguracoes.Visible = !panConfiguracoes.Visible;
            timer1.Enabled = false;
            btnComecar.Text = "Começar";
            frLblTable_MouseCaptureChanged(sender, e);
        }

        void Concluido()
        {
            bool correto = true;
            for (int n = 0; n < Quadradinhos.Length; n++)
                if (!(Quadradinhos[n].Text == Slots[n].Replace("&", "").Split('#')[0]))
                    correto = false;
            if (correto)
            {
                timer1.Enabled = false;
                Tempo = 0;
                btnComecar.Enabled = false;
                Jogando = false;
                panConfiguracoes.Visible = false;
                MessageBox.Show("Parabéns!");
                string temp = File.ReadAllText(Pasta + "\\" + ((referencia != null) ? (referencia) : (Arquivos[Mapa_Selecionado])), Encoding.UTF8);
                temp = temp.Replace("Não", "Sim");
                File.WriteAllText(Pasta + "\\" + ((referencia != null) ? (referencia) : (Arquivos[Mapa_Selecionado])), temp, Encoding.UTF8);
                if (referencia != null)
                {
                    File.Delete(Pasta + "\\" + Arquivos[Mapa_Selecionado]);
                    referencia = null;
                }
            }
        }

        void AtribuirMapa()
        {
            string[] tempmaps = (Directory.GetFiles(Pasta, "*.maps"));
            string[] temprec = (Directory.GetFiles(Pasta, "*.rec"));
            Arquivos = new string[tempmaps.Length + temprec.Length];
            Array.Copy(tempmaps, 0, Arquivos, 0, tempmaps.Length);
            Array.Copy(temprec, 0, Arquivos, tempmaps.Length, temprec.Length);
            for (int n = 0; n < Arquivos.Length; n++)
                Arquivos[n] = Arquivos[n].Replace(@"mapas\", "");
            Mapa_Selecionado = (Mapa_Selecionado >= Arquivos.Length) ? (0) : ((Mapa_Selecionado <= -1) ? (Arquivos.Length - 1) : (Mapa_Selecionado));
            Mapa = File.ReadAllText(Pasta + "\\" + Arquivos[Mapa_Selecionado], Encoding.UTF8).Split('|');
            //pegar dados
            Slots = new string[81];
            Array.Copy(Mapa[0].Split(' '), Slots, 81);
            lblDescricao.Text = Arquivos[Mapa_Selecionado];
            string[] config = Mapa[1].Split(' ');
            lblConcluído.Text = "Concluído: " + config[0];
            lblDificuldade.Text = "Dificuldade: " + config[1];
            if (config.Length == 4)
            {
                Tempo = int.Parse(config[2]);
                txtTimer.Text = TimeSpan.FromSeconds((double)Tempo).ToString();
                referencia = config[3];
            }
            //atribuir valor de CADA botão
            for (int n = 0; n < Quadradinhos.Length; n++)
                Quadradinhos[n].Text = (Slots[n].Contains('&') || Slots[n].Contains('#')) ? (Slots[n]) : ("");
        }
    }
}
