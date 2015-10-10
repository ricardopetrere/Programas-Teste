using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AtivarDesativarPerifericos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!BD_Connection.LeuBDXML())
                Application.Exit();
            else
                PreencherDataGridView();
        }
        void PreencherDataGridView()
        {
            dataGridView1.Rows.Clear();
            DataTable dt = BD_SQL.ExecutaSelect("select prf_sequencial,prf_codigo,prf_descricao,prt_estado from tbPeriferico");
            foreach (DataRow linha in dt.Rows)
            {
                dataGridView1.Rows.Add(new object[] { linha["prf_sequencial"], linha["prf_codigo"], linha["prf_descricao"], linha["prt_estado"] });
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                string sql = String.Format("update tbPeriferico set prt_estado = {0} where prf_sequencial = {1}",
                Convert.ToInt32(dataGridView1.CurrentRow.Cells["Estado"].EditedFormattedValue),
                Convert.ToInt32(dataGridView1.CurrentRow.Cells["Sequencial"].Value));
                BD_SQL.ExecutaSQL(sql);
                dataGridView1.EndEdit();
            }
        }

        private void btnConfigurarAcessoBD_Click(object sender, EventArgs e)
        {
            //frConexaoBD conexao = new frConexaoBD();
            //if (conexao.ShowDialog() == DialogResult.OK)
            //    PreencherDataGridView();
            //else
            //    Application.Exit();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }
    }
}
