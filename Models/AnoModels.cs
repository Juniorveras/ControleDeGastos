using ControleDeGastos.Controllers;
using ControleDeGastos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeGastos.Models
{
    public class AnoModels
    {
        public static int Inserir(CadastroAno obj)
        {
            return new AnoController().Inserir(obj);
        }
        public static int Editar(CadastroAno obj)
        {
            return new AnoController().Editar(obj);
        }
        public static int Excluir(CadastroAno obj)
        {
            return new AnoController().Excluir(obj);
        }

        public List<CadastroAno> Buscar(CadastroAno obj)
        {
            return new AnoController().Buscar(obj);
        }
        public List<CadastroAno> Listar(CadastroAno obj)
        {
            return new AnoController().Listar(obj);
        }
    }
}
