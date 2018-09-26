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

namespace ViewWPF.Views
{
    /// <summary>
    /// Lógica interna para TelaCompras.xaml
    /// </summary>
    public partial class TelaCompras : Window
    {
        public TelaCompras()
        {
            InitializeComponent();
            DataContext = new TelaComprasViewModel();
        }

        private void btnRegistrarCompra_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as TelaComprasViewModel).RegistrarProduto();
        }

        private void btnConcluirCompra_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as TelaComprasViewModel).RegistrarCompra();
        }
    }
}
