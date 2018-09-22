namespace Modelos.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelosContainer : DbContext
    {
        // Your context has been configured to use a 'ModelosContainer' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Modelos.DAL.ModelosContainer' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelosContainer' 
        // connection string in the application configuration file.
        public ModelosContainer() : base("name=ModelosContainer")
        {

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
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}