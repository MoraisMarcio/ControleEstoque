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
        }

        private void btnRegistrarVenda_Click(object sender, RoutedEventArgs e)
        {
            
            (DataContext as TelaVendasViewModel).RegistrarProduto();
        }

        private void btnConcluirVenda_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as TelaVendasViewModel).RegistrarVenda();
            (DataContext as TelaVendasViewModel).ListarProdutos();
        }
    }
}
