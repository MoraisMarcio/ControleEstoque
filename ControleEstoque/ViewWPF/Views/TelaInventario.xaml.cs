using Modelos;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            //List<Inventario> listaInventario = new List<Inventario>();
            //listaInventario = 
            (DataContext as TelaInventarioViewModel).ListarInventario();
            //listBoxListaInventario.Items.Add(listaInventario);
            //(DataContext as TelaInventarioViewModel).ListarInventario();
        }

        private void btnCriarInventario_Click(object sender, RoutedEventArgs e)
        {
            
            (DataContext as TelaInventarioViewModel).SalvarInventario();
            (DataContext as TelaInventarioViewModel).Nome = "";
        }

        //private void btnConsultar_Click(object sender, RoutedEventArgs e)
        //{
                                          

        //}


    }
}
