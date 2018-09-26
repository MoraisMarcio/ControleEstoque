using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class NotaEntrada
    {
        public int Id { get; set; }

        public int Numero { get; set; }

        public System.DateTime DataEntrada { get; set; }

        //public System.DateTime DataEmissao { get; set; }
        public decimal ValorTotal { get; set; }

        public int FornecedorId { get; set; }

        public virtual ICollection<ItemNotaEntrada> ItemNotaEntrada { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
    }
}
