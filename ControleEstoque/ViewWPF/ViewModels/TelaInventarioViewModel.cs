using Controllers;
using Modelos;
using System.ComponentModel;

namespace ViewWPF.ViewModels
{
    public class TelaInventarioViewModel : INotifyPropertyChanged
    {
        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Id"));
            }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Nome"));
            }
        }

        private int estoque;

        public int Estoque
        {
            get { return estoque; }
            set
            {
                estoque = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Estoque"));
            }
        }

        private int inventarioId;

        public int InventarioId
        {
            get { return inventarioId; }
            set
            {
                inventarioId = value;
                PropertyChanged(this, new PropertyChangedEventArgs("InventarioId"));
            }
        }

        private int produtoId;

        public int ProdutoId
        {
            get { return produtoId; }
            set
            {
                produtoId = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ProdutoId"));
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        public void SalvarInventario()
        {
            Inventario i = new Inventario();

            i.Id = Id;
            i.Nome = Nome;

            InventarioController inventarioController = new InventarioController();
            inventarioController.Inserir(i);
          
        }


        //public List<ItemInventario> Consultar()
        //{
        //    InventarioController inventarioController = new InventarioController();

        //    List<ItemInventario> lista = new List<ItemInventario>();
        //    lista = inventarioController.ConsultarInventario();

        //    return lista;

            
        //}
    }
}
