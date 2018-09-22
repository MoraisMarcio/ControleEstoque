using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ItemNotaSaida
    {
        public int Id { get; set; }
        public double Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public int ProdutoId { get; set; }
        public int NotaSaidaId { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual NotaSaida NotaSaida { get; set; }
    }
}
