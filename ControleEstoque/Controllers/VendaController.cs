using Modelos;
using Modelos.DAL;
using System;
using System.Collections.Generic;
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

        public void RegistrarVenda(NotaSaida n)
        {
            ModelosContainer contexto = new ModelosContainer();
            contexto.NotaSaidas.Add(n);
            contexto.SaveChanges();
        }
    }
}
