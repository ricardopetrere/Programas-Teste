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
    public partial class frEditor : Form
    {
        public frEditor()
        {
            InitializeComponent();
        }
        bool Correto = false;
        Label Selecionado;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Salvar_Click(object sender, EventArgs e)
        {/*
            Concluido();
            if(cbDificuldade.SelectedIndex>=0)
                if(Correto)
            if (lbMapas.SelectedIndex >=0)
            {
                File.AppendAllText(@"mapas\" + lbMapas.SelectedItem.ToString() + ".maps", 
                lbl1_1.Text + lbl1_2.Text + lbl1_3.Text + lbl1_4.Text + lbl1_5.Text + lbl1_6.Text + lbl1_7.Text + lbl1_8.Text + lbl1_9.Text + Environment.NewLine +
                lbl2_1.Text + lbl2_2.Text + lbl2_3.Text + lbl2_4.Text + lbl2_5.Text + lbl2_6.Text + lbl2_7.Text + lbl2_8.Text + lbl2_9.Text + Environment.NewLine +
                lbl3_1.Text + lbl3_2.Text + lbl3_3.Text + lbl3_4.Text + lbl3_5.Text + lbl3_6.Text + lbl3_7.Text + lbl3_8.Text + lbl3_9.Text + Environment.NewLine +
                lbl4_1.Text + lbl4_2.Text + lbl4_3.Text + lbl4_4.Text + lbl4_5.Text + lbl4_6.Text + lbl4_7.Text + lbl4_8.Text + lbl4_9.Text + Environment.NewLine +
                lbl5_1.Text + lbl5_2.Text + lbl5_3.Text + lbl5_4.Text + lbl5_5.Text + lbl5_6.Text + lbl5_7.Text + lbl5_8.Text + lbl5_9.Text + Environment.NewLine +
                lbl6_1.Text + lbl6_2.Text + lbl6_3.Text + lbl6_4.Text + lbl6_5.Text + lbl6_6.Text + lbl6_7.Text + lbl6_8.Text + lbl6_9.Text + Environment.NewLine +
                lbl7_1.Text + lbl7_2.Text + lbl7_3.Text + lbl7_4.Text + lbl7_5.Text + lbl7_6.Text + lbl7_7.Text + lbl7_8.Text + lbl7_9.Text + Environment.NewLine +
                lbl8_1.Text + lbl8_2.Text + lbl8_3.Text + lbl8_4.Text + lbl8_5.Text + lbl8_6.Text + lbl8_7.Text + lbl8_8.Text + lbl8_9.Text + Environment.NewLine +
                lbl9_1.Text + lbl9_2.Text + lbl9_3.Text + lbl9_4.Text + lbl9_5.Text + lbl9_6.Text + lbl9_7.Text + lbl9_8.Text + lbl9_9.Text + Environment.NewLine +
                false.ToString() + cbDificuldade.SelectedItem.ToString(), Encoding.UTF8);
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Preencha todos os campos corretamente");*/
        }

        private void frEditor_Load(object sender, EventArgs e)
        {
         //   lbMapas.Items.AddRange(frLblTable.Mapas);
            
        }

        void Concluido()
        {
            if (lbl1_1.Text.Length != 1)
                return;
            if (lbl1_2.Text.Length != 1)
                return;
            if (lbl1_3.Text.Length != 1)
                return;
            if (lbl1_4.Text.Length != 1)
                return;
            if (lbl1_5.Text.Length != 1)
                return;
            if (lbl1_6.Text.Length != 1)
                return;
            if (lbl1_7.Text.Length != 1)
                return;
            if (lbl1_8.Text.Length != 1)
                return;
            if (lbl1_9.Text.Length != 1)
                return;
            if (lbl2_1.Text.Length != 1)
                return;
            if (lbl2_2.Text.Length != 1)
                return;
            if (lbl2_3.Text.Length != 1)
                return;
            if (lbl2_4.Text.Length != 1)
                return;
            if (lbl2_5.Text.Length != 1)
                return;
            if (lbl2_6.Text.Length != 1)
                return;
            if (lbl2_7.Text.Length != 1)
                return;
            if (lbl2_8.Text.Length != 1)
                return;
            if (lbl2_9.Text.Length != 1)
                return;
            if (lbl3_1.Text.Length != 1)
                return;
            if (lbl3_2.Text.Length != 1)
                return;
            if (lbl3_3.Text.Length != 1)
                return;
            if (lbl3_4.Text.Length != 1)
                return;
            if (lbl3_5.Text.Length != 1)
                return;
            if (lbl3_6.Text.Length != 1)
                return;
            if (lbl3_7.Text.Length != 1)
                return;
            if (lbl3_8.Text.Length != 1)
                return;
            if (lbl3_9.Text.Length != 1)
                return;
            if (lbl4_1.Text.Length != 1)
                return;
            if (lbl4_2.Text.Length != 1)
                return;
            if (lbl4_3.Text.Length != 1)
                return;
            if (lbl4_4.Text.Length != 1)
                return;
            if (lbl4_5.Text.Length != 1)
                return;
            if (lbl4_6.Text.Length != 1)
                return;
            if (lbl4_7.Text.Length != 1)
                return;
            if (lbl4_8.Text.Length != 1)
                return;
            if (lbl4_9.Text.Length != 1)
                return;
            if (lbl5_1.Text.Length != 1)
                return;
            if (lbl5_2.Text.Length != 1)
                return;
            if (lbl5_3.Text.Length != 1)
                return;
            if (lbl5_4.Text.Length != 1)
                return;
            if (lbl5_5.Text.Length != 1)
                return;
            if (lbl5_6.Text.Length != 1)
                return;
            if (lbl5_7.Text.Length != 1)
                return;
            if (lbl5_8.Text.Length != 1)
                return;
            if (lbl5_9.Text.Length != 1)
                return;
            if (lbl6_1.Text.Length != 1)
                return;
            if (lbl6_2.Text.Length != 1)
                return;
            if (lbl6_3.Text.Length != 1)
                return;
            if (lbl6_4.Text.Length != 1)
                return;
            if (lbl6_5.Text.Length != 1)
                return;
            if (lbl6_6.Text.Length != 1)
                return;
            if (lbl6_7.Text.Length != 1)
                return;
            if (lbl6_8.Text.Length != 1)
                return ;
            if (lbl6_9.Text.Length != 1)
                return ;
            if (lbl7_1.Text.Length != 1)
                return ;
            if (lbl7_2.Text.Length != 1)
                return ;
            if (lbl7_3.Text.Length != 1)
                return ;
            if (lbl7_4.Text.Length != 1)
                return ;
            if (lbl7_5.Text.Length != 1)
                return ;
            if (lbl7_6.Text.Length != 1)
                return ;
            if (lbl7_7.Text.Length != 1)
                return ;
            if (lbl7_8.Text.Length != 1)
                return ;
            if (lbl7_9.Text.Length != 1)
                return ;
            if (lbl8_1.Text.Length != 1)
                return ;
            if (lbl8_2.Text.Length != 1)
                return ;
            if (lbl8_3.Text.Length != 1)
                return ;
            if (lbl8_4.Text.Length != 1)
                return ;
            if (lbl8_5.Text.Length != 1)
                return ;
            if (lbl8_6.Text.Length != 1)
                return ;
            if (lbl8_7.Text.Length != 1)
                return ;
            if (lbl8_8.Text.Length != 1)
                return ;
            if (lbl8_9.Text.Length != 1)
                return ;
            if (lbl9_1.Text.Length != 1)
                return ;
            if (lbl9_2.Text.Length != 1)
                return ;
            if (lbl9_3.Text.Length != 1)
                return ;
            if (lbl9_4.Text.Length != 1)
                return ;
            if (lbl9_5.Text.Length != 1)
                return ;
            if (lbl9_6.Text.Length != 1)
                return ;
            if (lbl9_7.Text.Length != 1)
                return ;
            if (lbl9_8.Text.Length != 1)
                return ;
            if (lbl9_9.Text.Length != 1)
                return ;
            Correto= true;
        }

        private void btnFixar_Click(object sender, EventArgs e)
        {
            Selecionado.Text = "&" + Selecionado.Text;
        }

        private void lbl1_1_Click(object sender, EventArgs e)
        {
            Selecionado = sender as Label;
        }

        private void lbl1_1_MouseCaptureChanged(object sender, EventArgs e)
        {
            Selecionado = sender as Label;
        }

        private void lbl1_1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
