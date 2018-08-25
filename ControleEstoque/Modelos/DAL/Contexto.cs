using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.DAL
{
    public class Contexto : DbContext  //  using System.Data.Entity;
    {
        public Contexto() : base("StringConexao")
        {
            //  App.config

            //          < connectionStrings >
            //            < add name = "StringConexao"

            //                connectionString =
            //                "Data Source=(localdb)\MSSQLLOCALDB;
            //                Initial Catalog = CodeFirstDB;
            //                Integrated Security = True"

            //                providerName = "System.Data.SqlClient"
            //            />
            //        </ connectionStrings >
        }

        public DbSet<Estoque> Estoques { get; set; } 

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Compra> Compras { get; set; }

        public DbSet<Fornecedor> Fornecedores { get; set; }

        public DbSet<ItemProduto> ItemProdutos { get; set; }

        public DbSet<Venda> Vendas { get; set; }
    }
}
