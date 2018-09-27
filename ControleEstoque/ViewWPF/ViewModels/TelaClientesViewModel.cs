using Controllers;
using Modelos;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ViewWPF.ViewModels
{
    public class TelaClientesViewModel : INotifyPropertyChanged
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

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set
            {
                telefone = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Telefone"));
            }
        }

        private string endereco;

        public string Endereco
        {
            get { return endereco; }
            set
            {
                endereco = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Endereco"));
            }
        }

        private ObservableCollection<Cliente> listaCliente;

        public ObservableCollection<Cliente> ListaCliente
        {
            get { return listaCliente; }
            set
            {
                listaCliente = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ListaCliente"));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void SalvarCliente()
        {
            // Instanciando cliente
            Cliente c = new Cliente();

            // Preenchendo os dados a serem salvos
            c.Id = Id;
            c.Nome = Nome;
            c.Telefone = Telefone;
            c.Endereco = Endereco;

            ClienteController clienteController = new ClienteController();
            clienteController.Inserir(c);
        }

        public void ListarClientes()
        {
            ClienteController clienteController = new ClienteController();
            listaCliente = clienteController.ListarTodosClientes();
        }
    }
}