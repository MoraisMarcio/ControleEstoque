using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewWPF.Clientes;
using ViewWPF.Fornecedores;
using ViewWPF.Produtos;
using ViewWPF.Vendas;

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
            TelaProdutosMenu minhaTelaProdutosMenu = new TelaProdutosMenu();
            minhaTelaProdutosMenu.Show();
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            TelaClientesMenu minhaTelaClientesMenu = new TelaClientesMenu();
            minhaTelaClientesMenu.Show();
        }

        private void btnFornecedores_Click(object sender, RoutedEventArgs e)
        {
            TelaFornecedoresMenu minhaTelaFornecedoresMenu = new TelaFornecedoresMenu();
            minhaTelaFornecedoresMenu.Show();
        }

        private void btnVendas_Click(object sender, RoutedEventArgs e)
        {
            TelaVendasMenu minhaTelaVendasMenu = new TelaVendasMenu();
            minhaTelaVendasMenu.Show();
        }
    }
}
