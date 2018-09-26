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
            (DataContext as TelaVendasViewModel).ClienteId = 0;
            (DataContext as TelaVendasViewModel).ProdutoId = 0;
            (DataContext as TelaVendasViewModel).Quantidade = 0;
            (DataContext as TelaVendasViewModel).ValorUnitario = 0;
        }

        private void btnConcluirVenda_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as TelaVendasViewModel).RegistrarVenda();           
        }
    }
}
