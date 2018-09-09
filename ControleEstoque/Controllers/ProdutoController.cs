using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class ProdutoController
    {
        void Inserir(Produto p)
        {
            ModelosContainer contexto = new ModelosContainer();
            contexto.Produtos.Add(p);
            contexto.SaveChanges();
        }

        List<Produto> ListarTodosProdutos()
        {
            ModelosContainer contexto = new ModelosContainer();
            return contexto.Produtos.ToList();
        }

        Produto BuscarPorId(int id)
        {
            ModelosContainer contexto = new ModelosContainer();
            return contexto.Produtos.Find(id);
        }

        void Excluir(int id)
        {
            Produto thisExcluir = BuscarPorId(id);

            if (thisExcluir != null)
            {
                ModelosContainer contexto = new ModelosContainer();
                contexto.Produtos.Remove(thisExcluir);
                contexto.SaveChanges();
            }
        }

        void Editar(int id, Produto dadosNovos)
        {
            Produto dadosAntigos = BuscarPorId(id);
            if (dadosAntigos != null)
            {
                dadosAntigos.Descricao = dadosNovos.Descricao;
                dadosAntigos.Unidade = dadosNovos.Unidade;
                dadosAntigos.PrecoCusto = dadosNovos.PrecoCusto;
                dadosAntigos.PrecoVenda = dadosNovos.PrecoVenda;
                dadosAntigos.EmEstoque = dadosNovos.EmEstoque;
                ModelosContainer contexto = new ModelosContainer();
                contexto.Entry(dadosAntigos).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        List<Produto> PersquisarPorNome(string descricao)
        {
            // LINQ
            // Exemplos para consulta de LINQs:
            // https://www.youtube.com/watch?v=lAdOdisVMWA

            ModelosContainer contexto = new ModelosContainer();

            //  var lista = from p in contexto.Produto
            //  select p;

            var lista = from p in contexto.Produtos
                        where p.Descricao == descricao
                        select p;

            return lista.ToList();
        }
    }
}
