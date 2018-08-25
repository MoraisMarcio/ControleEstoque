using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Compra
    {
        // PROPRIEDADES
        [Key]
        public int CompraId { get; set; }
        public DateTime Data { get; set; }

        // Chave Estrangeira
        public int FornecedorId { get; set; }

        // RELACIONAMENTO
    }
}
