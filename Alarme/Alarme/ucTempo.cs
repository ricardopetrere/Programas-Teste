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
    public partial class ucTempo : UserControl
    {
        public ucTempo()
        {
            InitializeComponent();
        }

        public TimeSpan Horario
        {
            get
            {
                return new TimeSpan(ucUnidadeHora.Valor, ucUnidadeMinuto.Valor, ucUnidadeSegundo.Valor);
            }
            set
            {
                ucUnidadeHora.Valor = value.Hours;
                ucUnidadeMinuto.Valor = value.Minutes;
                ucUnidadeSegundo.Valor = value.Seconds;
            }
        }
        public void AlteraHorario(TimeSpan ts)
        {
            Horario = Horario.Add(ts);
        }
        public void AlteraHorario(int qtdhoras, int qtdminutos, int qtdsegundos)
        {
            //o 1 dia é pra quando atingir 00:00:00 e for para subtrair tempo (pra evitar tempo negativo)
            AlteraHorario(new TimeSpan(1, qtdhoras, qtdminutos, qtdsegundos));
        }
        public void AlteraHorario(int segundos)
        {
            AlteraHorario(0, 0, segundos);
        }

        private void ucUnidadeHora_SetaPressionada(ucUnidadeTempo sender, Keys key)
        {
            switch (key)
            {
                case Keys.Up:
                    AlteraHorario((int)sender.UnidadeMedida);
                    break;
                case Keys.Down:
                    AlteraHorario(-(int)sender.UnidadeMedida);
                    break;
                case Keys.Left:
                    if (ucUnidadeSegundo.Focused)
                        ucUnidadeMinuto.Focus();
                    else if (ucUnidadeMinuto.Focused)
                        ucUnidadeHora.Focus();
                    break;
                case Keys.Right:
                    if (ucUnidadeHora.Focused)
                        ucUnidadeMinuto.Focus();
                    else if (ucUnidadeMinuto.Focused)
                        ucUnidadeSegundo.Focus();
                    break;
            }
        }
    }
}
