using Modelos;
using Controllers;
using System.ComponentModel;

namespace ViewWPF.ViewModels
{
    public class TelaProdutosViewModel : INotifyPropertyChanged
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

        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set
            {
                descricao = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Descricao"));
            }
        }

        private string unidade;

        public string Unidade
        {
            get { return unidade; }
            set
            {
                unidade = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Unidade"));
            }
        }

        private decimal precoCusto;

        public decimal PrecoCusto
        {
            get { return precoCusto; }
            set
            {
                precoCusto = value;
                PropertyChanged(this, new PropertyChangedEventArgs("PrecoCusto"));
            }
        }

        private int cod;

        public int Cod
        {
            get { return cod; }
            set
            {
                cod = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Cod"));
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

        public event PropertyChangedEventHandler PropertyChanged;

        public void SalvarProduto()
        {
            // Instanciando produto
            Produto p = new Produto();
            ItemInventario i = new ItemInventario();

            // Preenchendo os dados a serem salvos
            p.Id = Id;
            p.Descricao = Descricao;
            p.Unidade = Unidade;
            p.PrecoCusto = PrecoCusto;
            p.Cod = Cod;
            p.Estoque = Estoque;

            i.ProdutoId = Id;
            i.Estoque = Estoque;
            i.InventarioId = 1;

            ProdutoController prodController = new ProdutoController();
            prodController.Inserir(p, i);
        }
    }
}
