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
    public class TelaVendasViewModel : INotifyPropertyChanged
    {
        NotaSaida n = new NotaSaida();
        
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

        private int clienteId;

        public int ClienteId
        {
            get { return clienteId; }
            set
            {
                clienteId = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ClienteId"));
            }
        }

        private DateTime dataVenda;

        public DateTime DataVenda
        {
            get { return dataVenda; }
            set
            {
                dataVenda = value;
                PropertyChanged(this, new PropertyChangedEventArgs("DataVenda"));
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

        private double quantidade;

        public double Quantidade
        {
            get { return quantidade; }
            set
            {
                quantidade = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Quantidade"));
            }
        }

        private decimal valorUnitario;

        public decimal ValorUnitario
        {
            get { return valorUnitario; }
            set
            {
                valorUnitario = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ValorUnitario"));
            }
        }

        private string valorTotal;

        public string ValorTotal
        {
            get { return valorTotal; }
            set
            {
                valorTotal = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ValorTotal"));
            }
        }

        private string tipoPagamento;

        public string TipoPagamento
        {
            get { return tipoPagamento; }
            set
            {
                tipoPagamento = value;
                PropertyChanged(this, new PropertyChangedEventArgs("TipoPagamento"));
            }
        }

        //private int notaSaidaId;

        //public int NotaSaidaId
        //{
        //    get { return notaSaidaId; }
        //    set
        //    {
        //        notaSaidaId = value;
        //        PropertyChanged(this, new PropertyChangedEventArgs("NotaSaidaId"));
        //    }
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        public void RegistrarProduto()
        {
            // Instanciando objetos
            ItemNotaSaida i = new ItemNotaSaida();           

            // Preenchendo os dados a serem salvos
            i.Id = Id;
            i.ProdutoId = ProdutoId;
            i.Quantidade = Quantidade;
            i.ValorUnitario = ValorUnitario;
            //i.NotaSaidaId = NotaSaidaId;
            
            VendaController vendaController = new VendaController();
            vendaController.RegistrarProduto(i);
        }

        public void RegistrarVenda()
        {
            // SE HOUVEREM PRODUTOS REGISTRADOS, 
            // ENTÃO REGISTRE A VENDA:   

            n.DataVenda = DataVenda;
            n.ClienteId = ClienteId;
            n.ValorTotal = decimal.Parse(ValorTotal);
            n.TipoPagamento = TipoPagamento;
            VendaController vendaController = new VendaController();
            vendaController.RegistrarVenda(n);
        }
        
    }
}
