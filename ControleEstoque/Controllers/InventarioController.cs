using Modelos;
using Modelos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class InventarioController
    {
  
        public void Inserir(Inventario i)
        {
            ModelosContainer contexto = new ModelosContainer();
            contexto.Inventarios.Add(i);
        }

        public List<ItemInventario> ConsultarInventario()
        {
            ModelosContainer contexto = new ModelosContainer();
            return contexto.ItemInventarios.ToList();
        }

        //public Produto BuscarPorId(int id)
        //{
        //    ModelosContainer contexto = new ModelosContainer();
        //    return contexto.Produtos.Find(id);
        //}

        //public void Excluir(int id)
        //{
        //    Produto thisExcluir = BuscarPorId(id);

        //    if (thisExcluir != null)
        //    {
        //        ModelosContainer contexto = new ModelosContainer();
        //        contexto.Produtos.Remove(thisExcluir);
        //        contexto.SaveChanges();
        //    }
        //}

        //public void Editar(int id, Produto dadosNovos)
        //{
        //    Produto dadosAntigos = BuscarPorId(id);
        //    if (dadosAntigos != null)
        //    {
        //        dadosAntigos.Descricao = dadosNovos.Descricao;
        //        dadosAntigos.UN = dadosNovos.UN;
        //        dadosAntigos.PrecoCusto = dadosNovos.PrecoCusto;
        //        dadosAntigos.Cod = dadosNovos.Cod;
        //        dadosAntigos.Estoque = dadosNovos.Estoque;
        //        ModelosContainer contexto = new ModelosContainer();
        //        contexto.Entry(dadosAntigos).State = System.Data.Entity.EntityState.Modified;
        //        contexto.SaveChanges();
        //    }
        //}

        //public List<Produto> PersquisarPorNome(string descricao)
        //{
        //    // LINQ
        //    // Exemplos para consulta de LINQs:
        //    // https://www.youtube.com/watch?v=lAdOdisVMWA

        //    ModelosContainer contexto = new ModelosContainer();

        //    //  var lista = from p in contexto.Produto
        //    //  select p;

        //    var lista = from p in contexto.Produtos
        //                where p.Descricao == descricao
        //                select p;

        //    return lista.ToList();
        //}
    }
}
