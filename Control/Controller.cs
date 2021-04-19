using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Clínica_Exemplo.Control
{
    class Controller
    {
        public void Inserir()
        {
            using (SqlConnection con = new SqlConnection())
            {
                //SqlConnection conexao = new SqlConnection("Server = brconde\\sqlexpress; Database=clinica_exemplo.dbo; Username=bruno; Password=123456;");
                //con.ConnectionString = conexao;
                //SqlCommand cn = new SqlCommand();
                //cn.CommandType = CommandType.Text;

                //con.Open();
                //cn.CommandText = "INSERT INTO venda ([datas], [valor])" +
                //    " VALUES (@data, @valor)";
                //cn.Parameters.Add("data", SqlDbType.DateTime).Value = data;
                //cn.Parameters.Add("valor", SqlDbType.Float).Value = valor;
                //cn.Connection = con;

                //return cn.ExecuteNonQuery();
            }
        }

        public void CancelarVenda()
        {
            using (SqlConnection con = new SqlConnection())
            {
                //con.ConnectionString = Properties.Settings.Default.banco;
                //con.Open();
                //SqlCommand cn = con.CreateCommand();

                //cn.CommandText = "DELETE FROM venda WHERE codigo = @codigo";
                //cn.Parameters.Add("@codigo", SqlDbType.Int).Value = Codigo;

                //cn.ExecuteNonQuery();
                //con.Close();
            }
        }
    }
}
