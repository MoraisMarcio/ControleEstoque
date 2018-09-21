using Controllers;
using System.Windows;

namespace ViewWPF.Views
{
    /// <summary>
    /// Lógica interna para TelaInventario.xaml
    /// </summary>
    public partial class TelaInventario : Window
    {
        public TelaInventario()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            InventarioController inventarioController = new InventarioController();
            inventarioController.ConsultarInventario();
        }
    }
}
