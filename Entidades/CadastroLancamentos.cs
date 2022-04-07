using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeGastos.Entidades
{
    public class CadastroLancamentos
    {
        int Id_Lancamento;
        Tipo tipo;        
        string Descricao;
        decimal Valor;
        string Mes;
        int Id_Ano;
        DateTime Data;
        

        public int id_Lancamento { get => Id_Lancamento; set => Id_Lancamento = value; }
        public Tipo enumtipo { get => tipo; set => tipo = GetTipoProcessoByString(Convert.ToString(value)); }
        public string descricao { get => Descricao; set => Descricao = value; }
        public decimal valor { get => Valor; set => Valor = value; }
        public string mes { get => Mes; set => Mes = value; }
        public int id_Ano { get => Id_Ano; set => Id_Ano = value; }
        public DateTime data { get => Data; set => Data = value; }

        public static Tipo GetTipoProcessoByString(string tp)
        {
            switch (tp)
            {
                case "Entradas": return Tipo.Entradas;
                case "Saidas": return Tipo.Saidas;                    
            }
            return Tipo.Vazio;
        }
    }
    public enum Tipo 
    { 
        Entradas = 0,
        Saidas = 1,
        Vazio = 2
    }       

}
