using Controllers;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Consultar()
        {
            // Instanciando produto
            Produto p = new Produto();
            ItemInventario i = new ItemInventario();

            // Preenchendo os dados a serem salvos
            
            i.ProdutoId = Id;
            i.Estoque = Estoque;
            i.InventarioId = 1;

            InventarioController inventarioController = new InventarioController();
            inventarioController.ConsultarInventario();
        }
    }
}
