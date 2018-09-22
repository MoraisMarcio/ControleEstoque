using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ItemInventario
    {
        public int Id { get; set; }
        public int Estoque { get; set; }
        public int InventarioId { get; set; }
        public int ProdutoId { get; set; }

        public virtual Inventario Inventario { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
