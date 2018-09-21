using System.Windows;
using ViewWPF.ViewModels;

namespace ViewWPF.Views
{
    /// <summary>
    /// Lógica interna para TelaClientes.xaml
    /// </summary>
    public partial class TelaClientes : Window
    {
        public TelaClientes()
        {
            InitializeComponent();
            DataContext = new TelaClientesViewModel();
        }

        private void btnCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as TelaClientesViewModel).SalvarCliente();
        }
    }
}
