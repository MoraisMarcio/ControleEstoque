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
    class TelaFornecedoresMenuViewModel : INotifyPropertyChanged
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
            // Instanciando fornecedor
            Fornecedor f = new Fornecedor();

            // Preenchendo os dados a serem salvos
            f.Id = Id;
            f.Nome = Nome;
            
            FornecedorController fornecedorController = new FornecedorController();
            fornecedorController.Inserir(f);
        }
    }
}
