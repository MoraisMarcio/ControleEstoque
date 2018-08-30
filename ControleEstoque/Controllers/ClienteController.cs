using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class ClienteController
    {
        //void Inserir(Cliente c)
        //{
        //    baseDeDados contexto = new baseDeDados();
        //    contexto.Cliente.Add(c);
        //    contexto.SaveChanges();
        //}

        //List<Cliente> ListarTodosClientes()
        //{
        //    baseDeDados contexto = new baseDeDados();
        //    return contexto.Cliente.ToList();
        //}

        //Cliente BuscarPorID(int id)
        //{
        //    baseDeDados contexto = new baseDeDados();
        //    return contexto.Cliente.Find(id);
        //}

        //void Excluir(int id)
        //{
        //    Cliente thisExcluir = BuscarPorId(id);

        //    if (thisExcluir != null)
        //    {
        //        baseDeDados contexto = new baseDeDados();
        //        contexto.Cliente.Remove(thisExcluir);
        //        contexto.SaveChanges();
        //    }
        //}

        //void Editar(int id, Cliente dadosNovos)
        //{
        //    Cliente dadosAntigos = BuscarPorID(id);
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

        //List<Cliente> PersquisarPorNome(string nome)
        //{
        //    // LINQ
        //    // Exemplos para consulta de LINQs:
        //    // https://www.youtube.com/watch?v=lAdOdisVMWA

        //    baseDeDados contexto = new baseDeDados();

        //    //  var lista = from c in contexto.Cliente
        //    //  select c;

        //    var lista = from c in contexto.Cliente
        //                where c.Nome == nome
        //                select c;

        //    return lista.ToList();
        //}
    }
}
