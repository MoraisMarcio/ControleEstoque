using Modelos;
using Modelos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class FornecedorController
    {
        public void Inserir(Fornecedor f)
        {
            ModelosContainer contexto = new ModelosContainer();
            contexto.Fornecedores.Add(f);
            contexto.SaveChanges();
        }

        public List<Fornecedor> ListarTodosFornecedores()
        {
            ModelosContainer contexto = new ModelosContainer();
            return contexto.Fornecedores.ToList();
        }

        public Fornecedor BuscarPorId(int id)
        {
            ModelosContainer contexto = new ModelosContainer();
            return contexto.Fornecedores.Find(id);
        }

        public void Excluir(int id)
        {
            Fornecedor thisExcluir = BuscarPorId(id);

            if (thisExcluir != null)
            {
                ModelosContainer contexto = new ModelosContainer();
                contexto.Fornecedores.Remove(thisExcluir);
                contexto.SaveChanges();
            }
        }

        public void Editar(int id, Fornecedor dadosNovos)
        {
            Fornecedor dadosAntigos = BuscarPorId(id);
            if (dadosAntigos != null)
            {
                dadosAntigos.Nome = dadosNovos.Nome;
                ModelosContainer contexto = new ModelosContainer();
                contexto.Entry(dadosAntigos).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public List<Fornecedor> PersquisarPorNome(string nome)
        {
            // LINQ
            // Exemplos para consulta de LINQs:
            // https://www.youtube.com/watch?v=lAdOdisVMWA

            ModelosContainer contexto = new ModelosContainer();

            //  var lista = from f in contexto.Fornecedor
            //  select f;

            var lista = from f in contexto.Fornecedores
                        where f.Nome == nome
                        select f;

            return lista.ToList();
        }
    }
}
