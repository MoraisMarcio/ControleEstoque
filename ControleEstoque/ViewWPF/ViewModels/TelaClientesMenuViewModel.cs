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
    public class TelaClientesMenuViewModel : INotifyPropertyChanged
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

        private string bairro;

        public string Bairro
        {
            get { return bairro; }
            set
            {
                bairro = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Bairro"));
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

        private string numResidencial;

        public string NumResidencial
        {
            get { return numResidencial; }
            set
            {
                numResidencial = value;
                PropertyChanged(this, new PropertyChangedEventArgs("NumResidencial"));
            }
        }

        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set
            {
                cidade = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Cidade"));
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
            c.Bairro = Bairro;
            c.Endereco = Endereco;
            c.NumResidencial = NumResidencial;           
            c.Cidade = Cidade;

            ClienteController clienteController = new ClienteController();
            clienteController.Inserir(c);
        }
    }
}
