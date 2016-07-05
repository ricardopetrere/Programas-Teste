using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alarme
{
    public enum EnumValoresPorSegundo
    {
        HORA=3600,
        MINUTO=60,
        SEGUNDO=1
    }
    public partial class ucUnidadeTempo : UserControl
    {
        const string MASCARA = "00";
        private string ValorComMascara(int valor)
        {
            return valor.ToString(MASCARA);
        }
        public delegate void SetaPressionadaEventHandler(ucUnidadeTempo sender, Keys key);
        public event SetaPressionadaEventHandler SetaPressionada;
        public ucUnidadeTempo()
        {
            InitializeComponent();
        }
        public int Maximo
        {
            get;set;
        }
        private EnumValoresPorSegundo _unidademedida = EnumValoresPorSegundo.SEGUNDO;
        public EnumValoresPorSegundo UnidadeMedida
        {
            get
            {
                return _unidademedida;
            }
            set
            {
                _unidademedida = value;
                switch (_unidademedida)
                {
                    case EnumValoresPorSegundo.HORA:
                        label1.Text = "H";
                        break;
                    case EnumValoresPorSegundo.MINUTO:
                        label1.Text = "M";
                        break;
                    case EnumValoresPorSegundo.SEGUNDO:
                        label1.Text = "S";
                        break;
                }
            }
        }

        public int Valor
        {
            get
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                    return 0;
                return Convert.ToInt16(textBox1.Text);
            }
            set
            {
                textBox1.Text = ValorComMascara(value);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsLetter((char)e.KeyValue))
                e.SuppressKeyPress = true;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                    SetaPressionada?.Invoke(this, e.KeyCode);
                    break;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;
            string texto_novo = TextoSubstituido(e.KeyChar.ToString());
            int valor_novo = Valor;
            if (!int.TryParse(texto_novo, out valor_novo) || valor_novo >= Maximo)
            {
                e.Handled = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                textBox1.Text = ValorComMascara(0);
            else
                textBox1.Text = ValorComMascara(Valor);
        }
        public string TextoSubstituido(string texto_a_adicionar)
        {
            return textBox1.Text.Substring(0, textBox1.SelectionStart) + texto_a_adicionar + textBox1.Text.Substring(textBox1.SelectionStart+textBox1.SelectionLength);
        }
        public override bool Focused
        {
            get
            {
                return base.Focused || textBox1.Focused;
            }
        }
    }
}
