using System.Data.SqlClient;
using System.Data;

namespace Cadastrosv2
{
    class MetodosBD
    {
        public static SqlConnection Conectar()
        {
            SqlConnection conexao = new SqlConnection("Data Source=localhost;Initial Catalog=cadastros;User ID=sa;Password=123");
            conexao.Open();
            return conexao;
        }

        public static DataTable ExecutaSelect(string sql)
        {
            SqlConnection conexao = Conectar();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void ExecutaSQL(string sql)
        {
            SqlConnection conexao = Conectar();
            try
            {
                SqlCommand c = new SqlCommand(sql, conexao);
                c.ExecuteNonQuery();
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
