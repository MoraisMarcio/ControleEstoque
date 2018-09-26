using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewWPF.ViewModels
{
    public class TelaComprasViewModel : INotifyPropertyChanged
    {
        NotaEntrada n = new NotaEntrada();

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
       
        //public int NotaEntradaId { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RegistrarProduto()
        {
            // Instanciando objetos
            //ItemNotaSaida i = new ItemNotaSaida();

            // Preenchendo os dados a serem salvos
            //i.Id = Id;
            //i.ProdutoId = ProdutoId;
            //i.Quantidade = Quantidade;
            //i.ValorUnitario = ValorUnitario;
            //i.NotaSaidaId = n.Id;

            //VendaController vendaController = new VendaController();
            //vendaController.RegistrarProduto(i);
        }

        public void RegistrarCompra()
        {
            // SE HOUVEREM PRODUTOS REGISTRADOS, 
            // ENTÃO REGISTRE A VENDA:   

            //n.DataVenda = DataVenda;
            //n.ClienteId = ClienteId;
            //n.ValorTotal = ValorTotal;
            //n.TipoPagamento = TipoPagamento;
            //VendaController vendaController = new VendaController();
            //vendaController.RegistrarVenda(n);
        }
    }
}
