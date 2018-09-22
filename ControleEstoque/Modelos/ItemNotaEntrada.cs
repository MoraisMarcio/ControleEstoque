using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ItemNotaEntrada
    {
        public int Id { get; set; }
        public double Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public int ProdutoId { get; set; }
        public int NotaEntradaId { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual NotaEntrada NotaEntrada { get; set; }
    }
}
