using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Procedure
        {
            public static String Nome = "spTesteOutputParameter";
            public static String p_Char = "@Char";
            public static String p_Retorno = "@Retorno";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtRetorno.ResetText();
            char letra = (txtLetra.TextLength>0)?txtLetra.Text[0]:' ';
            //SqlConnectionStringBuilder connString = new SqlConnectionStringBuilder();
            //connString.DataSource = "RICARDO";
            //connString.InitialCatalog = "Banco_Teste";
            //connString.UserID = "sa";
            //connString.Password = "<senha>";
            //SqlConnection conn = new SqlConnection(connString.ConnectionString);
            SqlConnection conn = BD_SQL.Connection;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(Procedure.Nome, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(Procedure.p_Char, letra);
                cmd.Parameters.Add(Procedure.p_Retorno, SqlDbType.VarChar).Direction = ParameterDirection.Output;
                cmd.Parameters[Procedure.p_Retorno].Size = (int)numericUpDown1.Value;
                cmd.ExecuteNonQuery();
                String retorno = cmd.Parameters[Procedure.p_Retorno].Value.ToString();
                txtRetorno.Text = retorno;
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtLetra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

        /// <summary>
        /// Cria a procedure <code>spTesteOutputParameter</code> no banco de dados.
        /// </summary>
        //void CriarProcedure()
        //{
        //    int a = BD_SQL.ExecutaSQL(string.Format(
        //        "if exists(select * from sys.all_objects where name = 'spTesteOutputParameter')" + Environment.NewLine +
        //        "	drop procedure sptesteOutputparameter                                      " + Environment.NewLine +
        //        "go                                                                            " + Environment.NewLine +
        //        "CREATE PROCEDURE spTesteOutputParameter                                       " + Environment.NewLine +
        //        "	@Char varchar(1),                                                          " + Environment.NewLine +
        //        "	@Retorno varchar(255) output                                               " + Environment.NewLine +
        //        "AS                                                                            " + Environment.NewLine +
        //        "BEGIN                                                                         " + Environment.NewLine +
        //        "	if(lower(@Char)between 'a' and 'z')                                        " + Environment.NewLine +
        //        "	begin                                                                      " + Environment.NewLine +
        //        "		set @Retorno = 'Retornado: '+UPPER(@Char)                              " + Environment.NewLine +
        //        "	end                                                                        " + Environment.NewLine +
        //        "	select @Retorno Retorno                                                    " + Environment.NewLine +
        //        "END                                                                           " + Environment.NewLine +
        //        "GO                                                                            "
        //        ));
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!BD_Connection.LeuBDXML())
            {
                Application.Exit();
                return;
            }
            //CriarProcedure();
        }
    }
}
