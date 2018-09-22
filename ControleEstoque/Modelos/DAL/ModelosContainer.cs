using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.DAL
{
    public class ModelosContainer : DbContext
    {
        public ModelosContainer() : base("name=ModelosContainer")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Inventario> Inventarios { get; set; }
        public virtual DbSet<Fornecedor> Fornecedores { get; set; }
        public virtual DbSet<ItemInventario> ItemInventarios { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<ItemNotaEntrada> ItemNotaEntradas { get; set; }
        public virtual DbSet<NotaEntrada> NotaEntradas { get; set; }
        public virtual DbSet<ItemNotaSaida> ItemNotaSaidas { get; set; }
        public virtual DbSet<NotaSaida> NotaSaidas { get; set; }
        public virtual DbSet<Recebimento> Recebimentos { get; set; }
    }
}
