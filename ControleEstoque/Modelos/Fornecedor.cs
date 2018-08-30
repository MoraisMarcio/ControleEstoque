using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Fornecedor
    {
        // PROPRIEDADES
        [Key]
        public int FornecedorId { get; set; }

        [Required]
        public string Nome { get; set; }

        // RELACIONAMENTO
    }
}
