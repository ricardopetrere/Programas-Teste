using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ARESv2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmInteracao form2 = new frmInteracao();
            form2.interacao = 1;
            form2.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            frmInteracao form2 = new frmInteracao();
            form2.interacao = 2;
            form2.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmInteracao form2 = new frmInteracao();
            form2.interacao = 3;
            form2.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
