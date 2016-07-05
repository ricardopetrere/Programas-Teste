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
    public partial class ucGerenciadorTempo : UserControl
    {
        public ucGerenciadorTempo()
        {
            InitializeComponent();
        }

        public TimeSpan Horario
        {
            get
            {
                return ucTempo1.Horario;
            }
            set
            {
                ucTempo1.Horario = value;
            }
        }

        private void btnMaisHora_Click(object sender, EventArgs e)
        {
            ucTempo1.AlteraHorario(1, 0, 0);
        }

        private void btnMenosHora_Click(object sender, EventArgs e)
        {
            ucTempo1.AlteraHorario(-1, 0, 0);
        }

        private void btnMaisMinuto_Click(object sender, EventArgs e)
        {
            ucTempo1.AlteraHorario(0, 1, 0);
        }

        private void btnMenosMinuto_Click(object sender, EventArgs e)
        {
            ucTempo1.AlteraHorario(0, -1, 0);
        }

        private void btnMaisSegundo_Click(object sender, EventArgs e)
        {
            ucTempo1.AlteraHorario(0, 0, 1);
        }

        private void btnMenosSegundo_Click(object sender, EventArgs e)
        {
            ucTempo1.AlteraHorario(0, 0, -1);
        }
    }
}
