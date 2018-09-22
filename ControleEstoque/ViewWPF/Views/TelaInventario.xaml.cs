using System.Windows;
using ViewWPF.ViewModels;

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
            DataContext = new TelaInventarioViewModel();
        }

        private void btnCriarInventario_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as TelaInventarioViewModel).SalvarInventario();
        }

        //private void btnConsultar_Click(object sender, RoutedEventArgs e)
        //{
        //    List<ItemInventario> listaInventario = new List<ItemInventario>();
        //    listaInventario = (DataContext as TelaInventarioViewModel).Consultar();
        //    ListInventario.Items.Add(listaInventario);                               

        //}


    }
}
