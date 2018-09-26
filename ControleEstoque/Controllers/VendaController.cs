using Modelos;
using Modelos.DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class VendaController
    {
        public void RegistrarProduto(ItemNotaSaida i)
        {
            ModelosContainer contexto = new ModelosContainer();
            contexto.ItemNotaSaidas.Add(i);           
            contexto.SaveChanges();
        }

        public ObservableCollection<ItemNotaSaida> ListarVenda()
        {
            ModelosContainer contexto = new ModelosContainer();
            ObservableCollection<ItemNotaSaida> listaItemNotaSaida = new ObservableCollection<ItemNotaSaida>(contexto.ItemNotaSaidas.ToList());
            return listaItemNotaSaida;
        }

        public void RegistrarVenda(NotaSaida n)
        {
            ModelosContainer contexto = new ModelosContainer();
            contexto.NotaSaidas.Add(n);
            contexto.SaveChanges();
        }
    }
}
