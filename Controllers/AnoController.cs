using ControleDeGastos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeGastos.Controllers
{
    public class AnoController
    {
        public int Inserir(CadastroAno obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO [dbo].[Anos] ([ano]) VALUES (@ano)";
                cn.Parameters.Add("ano", SqlDbType.Int).Value = obj.ano;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                Console.WriteLine("O retorno da Query foi : " + qtd);
                return qtd;
            }
        }

        public List<CadastroAno> Buscar(CadastroAno obj)
        {
                using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Anos where Ano = @ano";
                cn.Parameters.Add("Ano", SqlDbType.Int).Value = obj.ano;
                cn.Connection = con;

                SqlDataReader dr;
                List<CadastroAno> lista = new List<CadastroAno>();
                dr = cn.ExecuteReader();
                while (dr.Read())
                    {
                        CadastroAno dados = new CadastroAno();
                        dados.id_Ano = Convert.ToInt32(dr["Id_Ano"]);
                        dados.ano = Convert.ToInt32(dr["Ano"]);
                        lista.Add(dados);
                    }               
                return lista;
            }
        }

        public List<CadastroAno> Listar(CadastroAno obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "SELECT * FROM Anos ORDER BY Ano";
                con.Open();
                //cn.Parameters.Add("Ano", SqlDbType.Int).Value = obj.ano;
                cn.Connection = con;

                SqlDataReader dr;
                List<CadastroAno> lista = new List<CadastroAno>();
                dr = cn.ExecuteReader();
                
                //Observar que o READ pode fazer vc avançar linhas quando usado de forma iregular como nesse caso do IF.
                while (dr.Read())
                    {
                        CadastroAno dados = new CadastroAno();
                        dados.id_Ano = Convert.ToInt32(dr["Id_Ano"]);
                        dados.ano = Convert.ToInt32(dr["Ano"]);
                        lista.Add(dados);
                    }
                return lista;
            }
        }

        public int Editar(CadastroAno obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE Anos SET Ano = @ano where Id_Ano = @id";
                cn.Parameters.Add("ano", SqlDbType.Int).Value = obj.ano;

                //Observar sempre os OBJETOS e suas IDENTIDADES. ATENÇÃO.
                cn.Parameters.Add("id", SqlDbType.Int).Value = obj.id_Ano;

                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                Console.WriteLine("O retorno da Query foi : " + qtd);
                return qtd;
            }
        }

        public int Excluir(CadastroAno obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "Delete from Anos where ano = @ano";
                cn.Parameters.Add("Ano", SqlDbType.Int).Value = obj.ano;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                Console.WriteLine("O retorno da Query foi : " + qtd);
                return qtd;
            }
        }
    }
}