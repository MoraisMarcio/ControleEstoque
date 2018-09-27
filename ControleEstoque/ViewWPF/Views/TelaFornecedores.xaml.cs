using System.Windows;
using ViewWPF.ViewModels;

namespace ViewWPF.Views
{
    /// <summary>
    /// Lógica interna para TelaFornecedores.xaml
    /// </summary>
    public partial class TelaFornecedores : Window
    {
        public TelaFornecedores()
        {
            InitializeComponent();
            DataContext = new TelaFornecedoresViewModel();
            (DataContext as TelaFornecedoresViewModel).ListarFornecedor();
        }

        private void btnCadastrarFornecedor_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as TelaFornecedoresViewModel).SalvarFornecedor();
            (DataContext as TelaFornecedoresViewModel).ListarFornecedor();
            campoNome.Text = "";
        }
    }
}
