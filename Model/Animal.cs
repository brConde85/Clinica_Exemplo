using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Clínica_Exemplo.Model
{
    class Animal
    {
        readonly Dono dono = new Dono();
        private int id_pet;        
        private string raca_pet;
        private string nome_pet;
        private string sexo;
        private string especie;
        private double peso;
        private string temperamento;
        private string observacao;
        private int id_dono;

        public int Id_pet { get => id_pet; set => id_pet = value; }

        public string Nome_pet { get => nome_pet; set => nome_pet = value; }

        public string Raca {  get => raca_pet; set => raca_pet = value; }

        public string Sexo {  get => sexo; set => sexo = value; }

        public string Especie {  get => especie; set => especie = value; }

        public double Peso {  get => peso; set => peso = value; }

        public string Temperamento {  get => temperamento; set => temperamento = value; }

        public string Observacao {  get => observacao; set => observacao = value; }

        public int Id_dono {  get => id_dono; set => id_dono = value; }

        public List<Animal> ListarPet()        
        {            
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;                
                con.Open();

                var comando = con.CreateCommand();
                comando.CommandText = "SELECT a.*, p.dono_id, p.nome AS nomeProprietario From Proprietario p, Animais a ORDER BY nomeProprietario";
                
                var reader =  comando.ExecuteReader();
                if (reader.HasRows)
                {
                    var lista = new List<Animal>();                    
                    while (reader.Read())
                    {                        
                        var animal = new Animal
                        {
                            id_pet = reader.GetInt32(0),
                            nome_pet = reader.GetString(1),
                            sexo = reader.GetString(2),
                            peso = reader.GetInt32(3),
                            raca_pet = reader.GetString(4),
                            especie = reader.GetString(5),
                            temperamento = reader.GetString(6),
                            observacao = reader.GetString(7),
                            id_dono = reader.GetInt32(8)
                            //dono = new Dono
                            //{
                            //    Id = reader.GetInt32(9),
                            //    Nome = reader.GetString(10),
                            //}
                        };

                        lista.Add(animal);
                    }
                    return lista;
                }
                return null;
            }
        }
        
        public void Inserir(string nomePet, double peso, string sexo, string raca, string especie, string temp, string obs, string nome_dono)
        {
            // instanciando sql connection para abrir uma conexão
            using (SqlConnection con = new SqlConnection())
            {
                try
                {
                    con.ConnectionString = Properties.Settings.Default.banco;
                    SqlCommand cn = new SqlCommand();
                    cn.CommandType = CommandType.Text;

                    // abrindo conexão com o banco                
                    con.Open();

                    cn.CommandText = "INSERT INTO Proprietario([nome]) VALUES(@nome_prop)";

                    cn.Parameters.AddWithValue("nome", nome_dono);

                    cn.CommandText = "INSERT INTO Animais ([nome_animal],[sexo],[quilos],[raca],[especie],[temperamento],[observacao],[id_prop]) " +
                        "VALUES (@nome, @sexo, @quilos, @raca, @especie, @temperamento, @observacao,)";

                    cn.Parameters.AddWithValue("@nome", nomePet);
                    cn.Parameters.AddWithValue("@sexo", sexo);
                    cn.Parameters.AddWithValue("@quilos", Convert.ToInt32(peso));
                    cn.Parameters.AddWithValue("@raca", raca);
                    cn.Parameters.AddWithValue("@especie", especie);
                    cn.Parameters.AddWithValue("@temperamento", temp);
                    cn.Parameters.AddWithValue("@observacao", obs);
                    cn.Parameters.AddWithValue("@id_prop", obs);

                    // Abrindo uma outra conexção
                    cn.Connection = con;

                    // retornando o execute 
                    cn.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                
            }
        }

        public int Atualizar(string status)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "UPDATE Animal a SET animal_id = '" + Id_pet + "' " +
                    "WHERE animal_id = @id_pet";
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = Id_pet;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }
        }
        public int Remover(int value)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();

                cn.CommandText = "DELETE FROM Proprietario WHERE " +
                    "dono_id = @id_dono";
                cn.Parameters.Add("id_dono", SqlDbType.Int).Value = Id_dono;

                cn.CommandText = "DELETE FROM Animais WHERE "+
                    "animal_id = @id_pet";
                cn.Parameters.Add("id_pet", SqlDbType.Int).Value = Id_pet;
                cn.Connection = con;

                return cn.ExecuteNonQuery();
            }
        }
    }
}
