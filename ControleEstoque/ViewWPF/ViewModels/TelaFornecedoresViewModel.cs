using Controllers;
using Modelos;
using System.ComponentModel;

namespace ViewWPF.ViewModels
{
    public class TelaFornecedoresViewModel : INotifyPropertyChanged
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

        public event PropertyChangedEventHandler PropertyChanged;

        public void SalvarFornecedor()
        {
            Fornecedor f = new Fornecedor();

            f.Id = Id;
            f.Nome = Nome;

            FornecedorController fornecedorController = new FornecedorController();
            fornecedorController.Inserir(f);
        }
    }
}
