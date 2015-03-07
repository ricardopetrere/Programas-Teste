using System;
using System.Data;

namespace Cadastrosv2
{ 
    //id int not null,
    //nome varchar(50),
    //data varchar(10),
    //email varchar(50),
    //endereco varchar(50),
    //cidade varchar(50),
    //num_telefone1 varchar(10),
    //desc_telefone1 varchar(50),
    //num_telefone2 varchar(10),
    //desc_telefone2 varchar(50),
    //num_telefone3 varchar(10),
    //desc_telefone3 varchar(50)

    class CadastroVO
    {
        int _Id;
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }
        string _Nome;
        public string Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                _Nome = value.Trim();
            }
        }
        string _Data;
        public string Data
        {
            get
            {
                return _Data;
            }
            set
            {
                _Data = value.Trim();
            }
        }
        string _Email;
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value.Trim();
            }
        }
        string _Endereco;
        public string Endereco
        {
            get
            {
                return _Endereco;
            }
            set
            {
                _Endereco = value.Trim();
            }
        }
        string _Cidade;
        public string Cidade
        {
            get
            {
                return _Cidade;
            }
            set
            {
                _Cidade = value.Trim();
            }
        }
        string _Num_Telefone1;
        public string Num_Telefone1
        {
            get
            {
                return _Num_Telefone1;
            }
            set
            {
                _Num_Telefone1 = value.Trim();
            }
        }
        string _Desc_Telefone1;
        public string Desc_Telefone1
        {
            get
            {
                return _Desc_Telefone1;
            }
            set
            {
                _Desc_Telefone1 = value.Trim();
            }
        }
        string _Num_Telefone2;
        public string Num_Telefone2
        {
            get
            {
                return _Num_Telefone2;
            }
            set
            {
                _Num_Telefone2 = value.Trim();
            }
        }
        string _Desc_Telefone2;
        public string Desc_Telefone2
        {
            get
            {
                return _Desc_Telefone2;
            }
            set
            {
                _Desc_Telefone2 = value.Trim();
            }
        }
        string _Num_Telefone3;
        public string Num_Telefone3
        {
            get
            {
                return _Num_Telefone3;
            }
            set
            {
                _Num_Telefone3 = value.Trim();
            }
        }
        string _Desc_Telefone3;
        public string Desc_Telefone3
        {
            get
            {
                return _Desc_Telefone3;
            }
            set
            {
                _Desc_Telefone3 = value.Trim();
            }
        }
    }

    class CadastroDAO
    {
        public static void Adicionar(CadastroVO c)
        {
            
            string sql = string.Format("insert into cadastros(id,nome,data,email,endereco,cidade,num_telefone1,desc_telefone1,num_telefone2,desc_telefone2,num_telefone3,desc_telefone3)" +
                                                   "values({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", c.Id, c.Nome, c.Data, c.Email, c.Endereco,
                                                   c.Cidade, c.Num_Telefone1, c.Desc_Telefone1, c.Num_Telefone2, c.Desc_Telefone2, c.Num_Telefone3, c.Desc_Telefone3);
            MetodosBD.ExecutaSQL(sql);
        }
        
        public static void Remover(int id)
        {
            string sql = "delete from cadastros where id=" + id.ToString();
            MetodosBD.ExecutaSQL(sql);
        }

        public static void Editar(CadastroVO c)
        {
            string sql = string.Format("update cadastros set nome='{1}',data='{2}',email='{3}',endereco='{4}',cidade='{5}'" +
                ",num_telefone1='{6}',desc_telefone1='{7}',num_telefone2='{8}',desc_telefone2='{9}',num_telefone3='{10}',desc_telefone3='{11}'" +
                "where id={0}", c.Id, c.Nome, c.Data, c.Email, c.Endereco, c.Cidade,
                c.Num_Telefone1, c.Desc_Telefone1, c.Num_Telefone2, c.Desc_Telefone2, c.Num_Telefone3, c.Desc_Telefone3);
            MetodosBD.ExecutaSQL(sql);
        }

        public static CadastroVO MontarVO(DataRow registro)
        {
            CadastroVO c = new CadastroVO();
            c.Id = Convert.ToInt16(registro["id"]);
            c.Nome = registro["nome"].ToString();
            c.Cidade = registro["cidade"].ToString();
            c.Data = registro["data"].ToString();
            c.Desc_Telefone1 = registro["desc_telefone1"].ToString();
            c.Desc_Telefone2 = registro["desc_telefone2"].ToString();
            c.Desc_Telefone3 = registro["desc_telefone3"].ToString();
            c.Email = registro["email"].ToString();
            c.Endereco = registro["endereco"].ToString();
            c.Num_Telefone1 = registro["num_telefone1"].ToString();
            c.Num_Telefone2 = registro["num_telefone2"].ToString();
            c.Num_Telefone3 = registro["num_telefone3"].ToString();
            return c;
        }
    }
}
