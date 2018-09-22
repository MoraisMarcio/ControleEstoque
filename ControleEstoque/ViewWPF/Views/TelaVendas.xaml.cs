using Modelos;
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
    /// Lógica interna para TelaVendas.xaml
    /// </summary>
    public partial class TelaVendas : Window
    {
        public TelaVendas()
        {
            InitializeComponent();            
            DataContext = new TelaVendasViewModel();          
        }

        private void btnRegistrarVenda_Click(object sender, RoutedEventArgs e)
        {
            
            (DataContext as TelaVendasViewModel).RegistrarProduto();
        }

        private void btnConcluirVenda_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as TelaVendasViewModel).RegistrarVenda();
        }
    }
}
