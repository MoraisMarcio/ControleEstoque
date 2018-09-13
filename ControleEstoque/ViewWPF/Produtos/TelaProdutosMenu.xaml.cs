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
using System.Windows.Shapes;
using ViewWPF.ViewModels;

namespace ViewWPF.Produtos
{
    /// <summary>
    /// Lógica interna para TelaProdutosMenu.xaml
    /// </summary>
    public partial class TelaProdutosMenu : Window
    {
        public TelaProdutosMenu()
        {
            InitializeComponent();
            DataContext = new TelaProdutoMenuViewModel();
        }

        private void btnCadastrarProduto_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as TelaProdutoMenuViewModel).SalvarProduto();
        }
    }
}
