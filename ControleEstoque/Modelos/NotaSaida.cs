using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class NotaSaida
    {
        public int Id { get; set; }
        public System.DateTime DataVenda { get; set; }
        public decimal ValorTotal { get; set; }
        public string TipoPagamento { get; set; }
        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<ItemNotaSaida> ItemNotaSaida { get; set; }      
        public virtual ICollection<Recebimento> Recebimento { get; set; }
    }
}
