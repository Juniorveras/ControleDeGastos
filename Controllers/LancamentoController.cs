using ControleDeGastos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeGastos.Controllers
{
    public class LancamentoController
    {
       public int Inserir(CadastroLancamentos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO [dbo].[Lancamentos] ([Tipo],[Descricao],[Valor],[Mes],[Id_Ano],[Data]) VALUES (@Tipo,@Descricao ,@Valor ,@Mes ,@Id_Ano ,@Data)";
                cn.Parameters.Add("Tipo", SqlDbType.NVarChar).Value = obj.enumtipo;
                cn.Parameters.Add("Descricao", SqlDbType.NVarChar).Value = obj.descricao;
                cn.Parameters.Add("Valor", SqlDbType.Decimal).Value = obj.valor;
                cn.Parameters.Add("Mes", SqlDbType.NVarChar).Value = obj.mes;
                cn.Parameters.Add("Id_Ano", SqlDbType.Int).Value = obj.id_Ano;
                cn.Parameters.Add("Data", SqlDbType.DateTime).Value = obj.data;
                cn.Connection = con;
                //Verificar(obj);
                int qtd = cn.ExecuteNonQuery();
                Console.WriteLine("O retorno da Query foi : " + qtd);
                return qtd;
            }
        }

        public List<CadastroLancamentos> Buscar(CadastroLancamentos obj)
        {
           using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * from lancamentos WHERE data = @data";
                cn.Parameters.Add("data", SqlDbType.DateTime).Value = obj.data;
                cn.Connection = con;

                SqlDataReader dr;
                List<CadastroLancamentos> lista = new List<CadastroLancamentos>();
                dr = cn.ExecuteReader();
                
                while (dr.Read())
                    {
                        CadastroLancamentos dado = new CadastroLancamentos();
                        dado.id_Lancamento = Convert.ToInt32(dr["id_lancamento"]);
                        dado.enumtipo = CadastroLancamentos.GetTipoProcessoByString((Convert.ToString(dr["tipo"])));
                        dado.descricao = Convert.ToString(dr["descricao"]);
                        dado.valor = Convert.ToDecimal(dr["valor"]);
                        dado.mes = Convert.ToString(dr["mes"]);
                        dado.id_Ano = Convert.ToInt32(dr["id_ano"]);
                        dado.data = Convert.ToDateTime(dr["data"]);
                        lista.Add(dado);
                    }
                
                return lista;
            }
        }
        public List<CadastroLancamentos> BuscarTipo(CadastroLancamentos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * from lancamentos WHERE tipo = @tipo order by id_lancamento";
                cn.Parameters.Add("tipo", SqlDbType.NVarChar).Value = obj.enumtipo;
                cn.Connection = con;

                SqlDataReader dr;
                List<CadastroLancamentos> lista = new List<CadastroLancamentos>();
                dr = cn.ExecuteReader();
                while (dr.Read())
                    {
                        CadastroLancamentos dado = new CadastroLancamentos();
                        dado.id_Lancamento = Convert.ToInt32(dr["id_lancamento"]);
                        dado.enumtipo = CadastroLancamentos.GetTipoProcessoByString((Convert.ToString(dr["tipo"])));
                        dado.descricao = Convert.ToString(dr["descricao"]);
                        dado.valor = Convert.ToDecimal(dr["valor"]);
                        dado.mes = Convert.ToString(dr["mes"]);
                        dado.id_Ano = Convert.ToInt32(dr["id_ano"]);
                        dado.data = Convert.ToDateTime(dr["data"]);
                        lista.Add(dado);
                    }
                
                return lista;
            }
        }
        public List<CadastroLancamentos> BuscarMes(CadastroLancamentos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                DateTime dtAtual = DateTime.Today;
                Int32 iDia = DateTime.DaysInMonth(dtAtual.Year, dtAtual.Month);
                DateTime dtUltimoDiaMes = new DateTime(dtAtual.Year, dtAtual.Month, iDia);

                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "Select lan.Id_Lancamento, lan.Tipo, lan.Descricao, lan.Valor, lan.Mes, a.Ano, lan.Id_Ano, lan.Data From Lancamentos lan INNER JOIN Anos a On a.Id_Ano = lan.Id_Ano where mes = @mes and ano = DATENAME(year, GetDate())";
                cn.Parameters.Add("Mes", SqlDbType.NVarChar).Value = obj.mes;
                cn.Connection = con;

                SqlDataReader dr;
                List<CadastroLancamentos> lista = new List<CadastroLancamentos>();
                dr = cn.ExecuteReader();
                while (dr.Read())
                {
                    CadastroLancamentos dado = new CadastroLancamentos();
                    dado.id_Lancamento = Convert.ToInt32(dr["id_lancamento"]);
                    dado.enumtipo = CadastroLancamentos.GetTipoProcessoByString((Convert.ToString(dr["tipo"])));
                    dado.descricao = Convert.ToString(dr["descricao"]);
                    dado.valor = Convert.ToDecimal(dr["valor"]);
                    dado.mes = Convert.ToString(dr["mes"]);
                    dado.id_Ano = Convert.ToInt32(dr["id_ano"]);
                    dado.data = Convert.ToDateTime(dr["data"]);
                    lista.Add(dado);
                }

                return lista;
            }
        }

        public List<CadastroLancamentos> Listar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "SELECT * FROM Lancamentos";
                con.Open();
                cn.Connection = con;

                SqlDataReader dr;
                List<CadastroLancamentos> lista = new List<CadastroLancamentos>();
                dr = cn.ExecuteReader();

                while (dr.Read())
                {
                    CadastroLancamentos dados = new CadastroLancamentos();
                    dados.id_Lancamento = Convert.ToInt32(dr["Id_Lancamento"]);
                    dados.enumtipo = CadastroLancamentos.GetTipoProcessoByString((Convert.ToString(dr["tipo"])));
                    dados.descricao = Convert.ToString(dr["Descricao"]);
                    dados.valor = Convert.ToDecimal(dr["Valor"]);
                    dados.mes = Convert.ToString(dr["Mes"]);
                    dados.id_Ano = Convert.ToInt32(dr["Id_Ano"]);
                    dados.data = Convert.ToDateTime(dr["data"]);
                    lista.Add(dados);
                }
                return lista;
            }
        }
        public List<CadastroLancamentos> ListarTodosEntradas()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "SELECT * FROM Lancamentos where tipo = @tipo order by data";
                cn.Parameters.Add("tipo", SqlDbType.NVarChar).Value = "Entradas";
                con.Open();
                cn.Connection = con;

                SqlDataReader dr;
                List<CadastroLancamentos> lista = new List<CadastroLancamentos>();
                dr = cn.ExecuteReader();

                while (dr.Read())
                {
                    CadastroLancamentos dados = new CadastroLancamentos();
                    dados.id_Lancamento = Convert.ToInt32(dr["Id_Lancamento"]);
                    dados.enumtipo = CadastroLancamentos.GetTipoProcessoByString((Convert.ToString(dr["tipo"])));
                    dados.descricao = Convert.ToString(dr["Descricao"]);
                    dados.valor = Convert.ToDecimal(dr["Valor"]);
                    dados.mes = Convert.ToString(dr["Mes"]);
                    dados.id_Ano = Convert.ToInt32(dr["Id_Ano"]);
                    dados.data = Convert.ToDateTime(dr["data"]);
                    lista.Add(dados);
                }
                return lista;
            }
        }
        public List<CadastroLancamentos> ListarTodosSaidas()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "SELECT * FROM Lancamentos where tipo = @tipo order by data";
                cn.Parameters.Add("tipo", SqlDbType.NVarChar).Value = "Saidas";
                con.Open();
                cn.Connection = con;

                SqlDataReader dr;
                List<CadastroLancamentos> lista = new List<CadastroLancamentos>();
                dr = cn.ExecuteReader();

                while (dr.Read())
                {
                    CadastroLancamentos dados = new CadastroLancamentos();
                    dados.id_Lancamento = Convert.ToInt32(dr["Id_Lancamento"]);
                    dados.enumtipo = CadastroLancamentos.GetTipoProcessoByString((Convert.ToString(dr["tipo"])));
                    dados.descricao = Convert.ToString(dr["Descricao"]);
                    dados.valor = Convert.ToDecimal(dr["Valor"]);
                    dados.mes = Convert.ToString(dr["Mes"]);
                    dados.id_Ano = Convert.ToInt32(dr["Id_Ano"]);
                    dados.data = Convert.ToDateTime(dr["data"]);
                    lista.Add(dados);
                }
                return lista;
            }
        }
        public List<CadastroLancamentos> BuscarDataTipoEntrada(CadastroLancamentos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Lancamentos where tipo = @tipo and data = @data";                
                cn.Parameters.Add("tipo", SqlDbType.NVarChar).Value = "Entradas";
                cn.Parameters.Add("data", SqlDbType.DateTime).Value = obj.data;
                cn.Connection = con;

                SqlDataReader dr;
                List<CadastroLancamentos> lista = new List<CadastroLancamentos>();
                dr = cn.ExecuteReader();

                while (dr.Read())
                {
                    CadastroLancamentos dado = new CadastroLancamentos();
                    dado.id_Lancamento = Convert.ToInt32(dr["id_lancamento"]);
                    dado.enumtipo = CadastroLancamentos.GetTipoProcessoByString((Convert.ToString(dr["tipo"])));
                    dado.descricao = Convert.ToString(dr["descricao"]);
                    dado.valor = Convert.ToDecimal(dr["valor"]);
                    dado.mes = Convert.ToString(dr["mes"]);
                    dado.id_Ano = Convert.ToInt32(dr["id_ano"]);
                    dado.data = Convert.ToDateTime(dr["data"]);
                    lista.Add(dado);
                }

                return lista;
            }
        }
        public List<CadastroLancamentos> BuscarDataEntradaMes(CadastroLancamentos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "Select lan.Id_Lancamento, lan.Tipo, lan.Descricao, lan.Valor, lan.Mes, a.Ano, lan.Id_Ano, lan.Data From Lancamentos lan INNER JOIN Anos a On a.Id_Ano = lan.Id_Ano where tipo = @tipo and mes = @mes and ano = DATENAME(year, GetDate())";
                cn.Parameters.Add("Mes", SqlDbType.NVarChar).Value = obj.mes;
                cn.Parameters.Add("tipo", SqlDbType.NVarChar).Value = "Entradas";
                cn.Connection = con;

                SqlDataReader dr;
                List<CadastroLancamentos> lista = new List<CadastroLancamentos>();
                dr = cn.ExecuteReader();

                while (dr.Read())
                {
                    CadastroLancamentos dado = new CadastroLancamentos();
                    dado.id_Lancamento = Convert.ToInt32(dr["id_lancamento"]);
                    dado.enumtipo = CadastroLancamentos.GetTipoProcessoByString((Convert.ToString(dr["tipo"])));
                    dado.descricao = Convert.ToString(dr["descricao"]);
                    dado.valor = Convert.ToDecimal(dr["valor"]);
                    dado.mes = Convert.ToString(dr["mes"]);
                    dado.id_Ano = Convert.ToInt32(dr["id_ano"]);
                    dado.data = Convert.ToDateTime(dr["data"]);
                    lista.Add(dado);
                }

                return lista;
            }
        }
        public List<CadastroLancamentos> BuscarDataSaidaMes(CadastroLancamentos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "Select lan.Id_Lancamento, lan.Tipo, lan.Descricao, lan.Valor, lan.Mes, a.Ano, lan.Id_Ano, lan.Data From Lancamentos lan INNER JOIN Anos a On a.Id_Ano = lan.Id_Ano where tipo = @tipo and mes = @mes and ano = DATENAME(year, GetDate())";
                cn.Parameters.Add("Mes", SqlDbType.NVarChar).Value = obj.mes;
                cn.Parameters.Add("tipo", SqlDbType.NVarChar).Value = "Saidas";
                cn.Connection = con;

                SqlDataReader dr;
                List<CadastroLancamentos> lista = new List<CadastroLancamentos>();
                dr = cn.ExecuteReader();

                while (dr.Read())
                {
                    CadastroLancamentos dado = new CadastroLancamentos();
                    dado.id_Lancamento = Convert.ToInt32(dr["id_lancamento"]);
                    dado.enumtipo = CadastroLancamentos.GetTipoProcessoByString((Convert.ToString(dr["tipo"])));
                    dado.descricao = Convert.ToString(dr["descricao"]);
                    dado.valor = Convert.ToDecimal(dr["valor"]);
                    dado.mes = Convert.ToString(dr["mes"]);
                    dado.id_Ano = Convert.ToInt32(dr["id_ano"]);
                    dado.data = Convert.ToDateTime(dr["data"]);
                    lista.Add(dado);
                }

                return lista;
            }
        }
        public List<CadastroLancamentos> BuscarDataTipoSaida(CadastroLancamentos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Lancamentos where tipo = @tipo and data = @data";
                cn.Parameters.Add("tipo", SqlDbType.NVarChar).Value = "Saidas";
                cn.Parameters.Add("data", SqlDbType.DateTime).Value = obj.data;
                cn.Connection = con;

                SqlDataReader dr;
                List<CadastroLancamentos> lista = new List<CadastroLancamentos>();
                dr = cn.ExecuteReader();

                while (dr.Read())
                {
                    CadastroLancamentos dado = new CadastroLancamentos();
                    dado.id_Lancamento = Convert.ToInt32(dr["id_lancamento"]);
                    dado.enumtipo = CadastroLancamentos.GetTipoProcessoByString((Convert.ToString(dr["tipo"])));
                    dado.descricao = Convert.ToString(dr["descricao"]);
                    dado.valor = Convert.ToDecimal(dr["valor"]);
                    dado.mes = Convert.ToString(dr["mes"]);
                    dado.id_Ano = Convert.ToInt32(dr["id_ano"]);
                    dado.data = Convert.ToDateTime(dr["data"]);
                    lista.Add(dado);
                }

                return lista;
            }
        }


        public int Editar(CadastroLancamentos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE Lancamentos SET Tipo = @tipo, Descricao = @Descricao, Valor = @Valor, Mes = @Mes, Id_Ano = @Id_Ano, Data = @Data where Id_lancamento = @Id";
                
                cn.Parameters.Add("Tipo", SqlDbType.NVarChar).Value = obj.enumtipo;
                cn.Parameters.Add("Descricao", SqlDbType.NVarChar).Value = obj.descricao;
                cn.Parameters.Add("Valor", SqlDbType.Decimal).Value = obj.valor;
                cn.Parameters.Add("Mes", SqlDbType.NVarChar).Value = obj.mes;
                cn.Parameters.Add("Id_Ano", SqlDbType.Int).Value = obj.id_Ano;
                cn.Parameters.Add("Data", SqlDbType.DateTime).Value = obj.data;
                cn.Parameters.Add("Id", SqlDbType.Int).Value = obj.id_Lancamento;
                cn.Connection = con;
                
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }

        public int Excluir(CadastroLancamentos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "Delete from Lancamentos where Id_Lancamento = @Id";
                cn.Parameters.Add("Id", SqlDbType.Int).Value = obj.id_Lancamento;
                cn.Connection = con;
                //Verificar(obj);
                int qtd = cn.ExecuteNonQuery();
                Console.WriteLine("O retorno da Query foi : " + qtd);
                return qtd;
            }
        }      
       
    }
}
