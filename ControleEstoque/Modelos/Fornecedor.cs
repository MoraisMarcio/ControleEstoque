using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<NotaEntrada> NotaEntrada { get; set; }
    }
}
