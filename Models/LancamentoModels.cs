using ControleDeGastos.Controllers;
using ControleDeGastos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeGastos.Models
{
    public class LancamentoModels
    {
        public static int Inserir(CadastroLancamentos obj)
        {
            return new LancamentoController().Inserir(obj);
        }
        public static int Editar(CadastroLancamentos obj)
        {
            return new LancamentoController().Editar(obj);
        }
        public static int Excluir(CadastroLancamentos obj)
        {
            return new LancamentoController().Excluir(obj);
        }
        public List<CadastroLancamentos> Buscar(CadastroLancamentos obj)
        {
            return new LancamentoController().Buscar(obj);
        }
        public List<CadastroLancamentos> BuscarTipo(CadastroLancamentos obj)
        {
            return new LancamentoController().BuscarTipo(obj);
        }
        public List<CadastroLancamentos> BuscarDataTipoEntrada(CadastroLancamentos obj)
        {
            return new LancamentoController().BuscarDataTipoEntrada(obj);
        }
        public List<CadastroLancamentos> BuscarDataTipoSaida(CadastroLancamentos obj)
        {
            return new LancamentoController().BuscarDataTipoSaida(obj);
        }
        public List<CadastroLancamentos> BuscarDataEntradaMes(CadastroLancamentos obj)
        {
            return new LancamentoController().BuscarDataEntradaMes(obj);
        }
        public List<CadastroLancamentos> BuscarDataSaidaMes(CadastroLancamentos obj)
        {
            return new LancamentoController().BuscarDataSaidaMes(obj);
        }
        public List<CadastroLancamentos> BuscarMes(CadastroLancamentos obj)
        {
            return new LancamentoController().BuscarMes(obj);
        }
        public List<CadastroLancamentos> ListarTodosEntradas()
        {
            return new LancamentoController().ListarTodosEntradas();
        }
        public List<CadastroLancamentos> ListarTodosSaidas()
        {
            return new LancamentoController().ListarTodosSaidas();
        }
        public List<CadastroLancamentos> Listar()
        {
            return new LancamentoController().Listar();
        }
    }
}
