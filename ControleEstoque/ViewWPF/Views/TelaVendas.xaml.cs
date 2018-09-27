using System.Windows;
using ViewWPF.ViewModels;

namespace ViewWPF.Views
{
    /// <summary>
    /// Lógica interna para TelaVendas.xaml
    /// </summary>
    public partial class TelaVendas : Window
    {
        public TelaVendas()
        {
            InitializeComponent();            
            DataContext = new TelaVendasViewModel();
            (DataContext as TelaVendasViewModel).ListarProdutos();
        }

        private void btnRegistrarVenda_Click(object sender, RoutedEventArgs e)
        {            
            (DataContext as TelaVendasViewModel).RegistrarProduto();
            (DataContext as TelaVendasViewModel).ListarProdutos();
            campoValorUnitario.Text = "";
            campoQuantidade.Text = "";
            campoValorTotal.Text = "";
            comboCliente.Text = "";
            comboPagamento.Text = "";
            comboProduto.Text = "";
        }

        private void btnConcluirVenda_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as TelaVendasViewModel).RegistrarVenda();           
        }
    }
}
