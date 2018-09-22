using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Recebimento
    {
        public int Id { get; set; }
        public System.DateTime DataVendimento { get; set; }
        public decimal Valor { get; set; }
        public int NotaSaidaId { get; set; }

        public virtual NotaSaida NotaSaida { get; set; }
    }
}
