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
            (DataContext as TelaInventarioViewModel).ListarInventario();
        
        }

        private void btnCriarInventario_Click(object sender, RoutedEventArgs e)
        {           
            (DataContext as TelaInventarioViewModel).SalvarInventario();            
            //(DataContext as TelaInventarioViewModel).ListarInventario();
            (DataContext as TelaInventarioViewModel).Nome = "";          
        }

    }
}
