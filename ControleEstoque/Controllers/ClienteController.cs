using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ClienteController
    {
        public void Inserir(Cliente c)
        {
            ModelosContainer contexto = new ModelosContainer();
            contexto.Clientes.Add(c);
            contexto.SaveChanges();
        }

        public List<Cliente> ListarTodosClientes()
        {
            ModelosContainer contexto = new ModelosContainer();
            return contexto.Clientes.ToList();
        }

        public Cliente BuscarPorId(int id)
        {
            ModelosContainer contexto = new ModelosContainer();
            return contexto.Clientes.Find(id);
        }

        public void Excluir(int id)
        {
            Cliente thisExcluir = BuscarPorId(id);

            if (thisExcluir != null)
            {
                ModelosContainer contexto = new ModelosContainer();
                contexto.Clientes.Remove(thisExcluir);
                contexto.SaveChanges();
            }
        }

        public void Editar(int id, Cliente dadosNovos)
        {
            Cliente dadosAntigos = BuscarPorId(id);
            if (dadosAntigos != null)
            {
                dadosAntigos.Nome = dadosNovos.Nome;
                dadosAntigos.Telefone = dadosNovos.Telefone;
                dadosAntigos.Bairro = dadosNovos.Bairro;
                dadosAntigos.Endereco = dadosNovos.Endereco;
                dadosAntigos.NumResidencial = dadosNovos.NumResidencial;
                dadosAntigos.Cidade = dadosNovos.Cidade;
                ModelosContainer contexto = new ModelosContainer();
                contexto.Entry(dadosAntigos).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public List<Cliente> PersquisarPorNome(string nome)
        {
            // LINQ
            // Exemplos para consulta de LINQs:
            // https://www.youtube.com/watch?v=lAdOdisVMWA

            ModelosContainer contexto = new ModelosContainer();

            //  var lista = from c in contexto.Clientes
            //  select c;

            var lista = from c in contexto.Clientes
                        where c.Nome == nome
                        select c;

            return lista.ToList();
        }
    }
}
