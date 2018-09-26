using Controllers;
using Modelos;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private ObservableCollection<Inventario> listaInventario;

        public ObservableCollection<Inventario> ListaInventario
        {
            get { return listaInventario; }
            set
            {
                listaInventario = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ListaInventario"));
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

        public void ListarInventario()
        {
            InventarioController inventarioController = new InventarioController();
            listaInventario = inventarioController.ConsultarInventario();
             
        }

        //public ObservableCollection<Inventario> ListarInventario()
        //{
        //    InventarioController inventarioController = new InventarioController();

        //    ObservableCollection<Inventario> lista = new ObservableCollection<Inventario>;
        //    lista = inventarioController.ConsultarInventario();

        //    return lista;         
        //}
    }
}
