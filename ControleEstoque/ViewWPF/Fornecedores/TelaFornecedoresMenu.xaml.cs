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

namespace ViewWPF.Fornecedores
{
    /// <summary>
    /// Lógica interna para TelaFornecedoresMenu.xaml
    /// </summary>
    public partial class TelaFornecedoresMenu : Window
    {
        public TelaFornecedoresMenu()
        {
            InitializeComponent();
            DataContext = new TelaFornecedoresMenuViewModel();
        }

        private void btnCadastrarFornecedor_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as TelaFornecedoresMenuViewModel).SalvarFornecedor();
        }
    }
}
