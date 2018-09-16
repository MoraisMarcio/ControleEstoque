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
    public class TelaProdutosMenuViewModel : INotifyPropertyChanged
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

        private decimal precoVenda;

        public decimal PrecoVenda
        {
            get { return precoVenda; }
            set
            {
                precoVenda = value;
                PropertyChanged(this, new PropertyChangedEventArgs("PrecoVenda"));
            }
        }

        private double emEstoque;

        public double EmEstoque
        {
            get { return emEstoque; }
            set
            {
                emEstoque = value;
                PropertyChanged(this, new PropertyChangedEventArgs("EmEstoque"));
            }
        }
     
       // public int EstoqueId { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void SalvarProduto()
        {
            // Instanciando produto
            Produto p = new Produto();

            // Preenchendo os dados a serem salvos
            p.Id = Id;
            p.Descricao = Descricao;
            p.Unidade = Unidade;
            p.PrecoCusto = PrecoCusto;
            p.PrecoVenda = PrecoVenda;
            p.EmEstoque = EmEstoque;

            ProdutoController prodController = new ProdutoController();
            prodController.Inserir(p);
        }


    }
}
