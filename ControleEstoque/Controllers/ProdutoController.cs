using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class ProdutoController
    {
        //void Inserir(Produto p)
        //{
        //    baseDeDados contexto = new baseDeDados();
        //    contexto.Produto.Add(p);
        //    contexto.SaveChanges();
        //}

        //List<Produto> ListarTodosProdutos()
        //{
        //    baseDeDados contexto = new baseDeDados();
        //    return contexto.Produto.ToList();
        //}

        //Produto BuscarPorId(int id)
        //{
        //    baseDeDados contexto = new baseDeDados();
        //    return contexto.Produto.Find(id);
        //}

        //void Excluir(int id)
        //{
        //    Produto thisExcluir = BuscarPorId(id);

        //    if (thisExcluir != null)
        //    {
        //        baseDeDados contexto = new baseDeDados();
        //        contexto.Produto.Remove(thisExcluir);
        //        contexto.SaveChanges();
        //    }
        //}

        //void Editar(int id, Produto dadosNovos)
        //{
        //    Produto dadosAntigos = BuscarPorId(id);
        //    if (dadosAntigos != null)
        //    {
        //        dadosAntigos.Descricao = dadosNovos.Descricao;
        //        dadosAntigos.Unidade = dadosNovos.Unidade;
        //        dadosAntigos.PrecoCusto = dadosNovos.PrecoCusto;
        //        dadosAntigos.PrecoVenda = dadosNovos.PrecoVenda;
        //        dadosAntigos.EmEstoque = dadosNovos.EmEstoque;
        //        baseDeDados contexto = new baseDeDados();
        //        contexto.Entry(dadosAntigos).State = System.Data.Entity.EntityState.Modified;
        //        contexto.SaveChanges();
        //    }
        //}

        //List<Produto> PersquisarPorNome(string nome)
        //{
        //    // LINQ
        //    // Exemplos para consulta de LINQs:
        //    // https://www.youtube.com/watch?v=lAdOdisVMWA

        //    baseDeDados contexto = new baseDeDados();

        //    //  var lista = from p in contexto.Produto
        //    //  select p;

        //    var lista = from p in contexto.Produto
        //                where p.Nome == nome
        //                select p;

        //    return lista.ToList();
        //}
    }
}
