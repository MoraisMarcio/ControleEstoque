using System.Windows;
using ViewWPF.Views;

namespace ViewWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnProdutos_Click(object sender, RoutedEventArgs e)
        {           
                TelaProdutos minhaTelaProdutosMenu = new TelaProdutos();
                minhaTelaProdutosMenu.Show();           
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            TelaClientes minhaTelaClientes = new TelaClientes();
            minhaTelaClientes.Show();
        }

        private void btnFornecedores_Click(object sender, RoutedEventArgs e)
        {
            TelaFornecedores minhaTelaFornecedores = new TelaFornecedores();
            minhaTelaFornecedores.Show();
        }

        private void btnInventario_Click(object sender, RoutedEventArgs e)
        {
            TelaInventario minhaTelaInventario = new TelaInventario();
            minhaTelaInventario.Show();
        }
    }
}
