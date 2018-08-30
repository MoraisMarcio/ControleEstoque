using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class FornecedorController
    {
        //void Inserir(Fornecedor f)
        //{
        //    baseDeDados contexto = new baseDeDados();
        //    contexto.Fornecedor.Add(f);
        //    contexto.SaveChanges();
        //}

        //List<Fornecedor> ListarTodosFornecedores()
        //{
        //    baseDeDados contexto = new baseDeDados();
        //    return contexto.Fornecedor.ToList();
        //}

        //Fornecedor BuscarPorId(int id)
        //{
        //    baseDeDados contexto = new baseDeDados();
        //    return contexto.Fornecedor.Find(id);
        //}

        //void Excluir(int id)
        //{
        //    Fornecedor thisExcluir = BuscarPorId(id);

        //    if (thisExcluir != null)
        //    {
        //        baseDeDados contexto = new baseDeDados();
        //        contexto.Fornecedor.Remove(thisExcluir);
        //        contexto.SaveChanges();
        //    }
        //}

        //void Editar(int id, Fornecedor dadosNovos)
        //{
        //    Fornecedor dadosAntigos = BuscarPorId(id);
        //    if (dadosAntigos != null)
        //    {
        //        dadosAntigos.Nome = dadosNovos.Nome;
        //        dadosAntigos.Telefone = dadosNovos.Telefone;
        //        dadosAntigos.Bairro = dadosNovos.Bairro;
        //        dadosAntigos.Endereco = dadosNovos.Endereco;
        //        dadosAntigos.NumResidencial = dadosNovos.NumResidencial;
        //        dadosAntigos.Cidade = dadosNovos.Cidade;
        //        baseDeDados contexto = new baseDeDados();
        //        contexto.Entry(dadosAntigos).State = System.Data.Entity.EntityState.Modified;
        //        contexto.SaveChanges();
        //    }
        //}

        //List<Fornecedor> PersquisarPorNome(string nome)
        //{
        //    // LINQ
        //    // Exemplos para consulta de LINQs:
        //    // https://www.youtube.com/watch?v=lAdOdisVMWA

        //    baseDeDados contexto = new baseDeDados();

        //    //  var lista = from f in contexto.Fornecedor
        //    //  select f;

        //    var lista = from f in contexto.Fornecedor
        //                where f.Nome == nome
        //                select f;

        //    return lista.ToList();
        //}
    }
}
