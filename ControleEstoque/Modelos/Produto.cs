using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Produto
    {
        public int Id { get; set; }
        public int Cod { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        public decimal PrecoCusto { get; set; }
        public int Estoque { get; set; }

        public virtual ICollection<ItemInventario> ItemInventario { get; set; }
        public virtual ICollection<ItemNotaEntrada> ItemNotaEntrada { get; set; }
        public virtual ICollection<ItemNotaSaida> ItemNotaSaida { get; set; }
    }
}
