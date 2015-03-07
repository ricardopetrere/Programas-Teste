using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculaGanhosPoupanca
{
    public enum MENSAGENS { ERRO_OBRIGATORIO, ERRO_CONVERSAO_NUMERICO};
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool IsValid=true;
            
        private void btnTotalFuturo_Calcular_Click(object sender, EventArgs e)
        {
            ClearErrorProvider1();
            double ValorInicial, InvestimentoMensal, Periodo, TaxaDeJuros;
            double ValorTotal;
            //Validações de campos de entrada
            ValorInicial = ValidaCampo(txtTotalFuturo_Val_Inicial, false);
            InvestimentoMensal = ValidaCampo(txtTotalFuturo_Inv_Mensal, true);
            Periodo = ValidaCampo(txtTotalFuturo_Periodo, true);
            TaxaDeJuros = ValidaCampo(txtTotalFuturo_Juros, true);
            if(IsValid)
            {

            }
        }

        void SetErrorProvider1(Control ctr,MENSAGENS erro)
        {
            if(erro==MENSAGENS.ERRO_OBRIGATORIO)
                errorProvider1.SetError(ctr, "Campo obrigatório.");
            else
                errorProvider1.SetError(ctr, "Valor deve ser numérico.");
            IsValid = false;
        }
        void ClearErrorProvider1()
        {
            errorProvider1.Clear();
            IsValid = true;
        }

        double ValidaCampo(TextBox campo, bool obrigatorio)
        {
            double retorno = 0;
            if(obrigatorio)
            {
                if (campo.Text.Trim() == String.Empty)
                    SetErrorProvider1(campo, MENSAGENS.ERRO_OBRIGATORIO);
                else if (!double.TryParse(campo.Text, out retorno))
                    SetErrorProvider1(campo, MENSAGENS.ERRO_CONVERSAO_NUMERICO);
            }
            else
            {
                if (campo.Text.Trim() != String.Empty
                && !double.TryParse(campo.Text, out retorno))
                    SetErrorProvider1(campo, MENSAGENS.ERRO_CONVERSAO_NUMERICO);
            }
            return retorno;
        }
    }
}
