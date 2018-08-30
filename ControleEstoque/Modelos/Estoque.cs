using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Estoque
    {
        // PROPRIEDADES
        [Key]
        public int EstoqueId { get; set; }

        [Required]
        public string Nome { get; set; }

        // Chave Estrangeira
        public int ProdutoId { get; set; }

        // RELACIONAMENTO
    }
}
