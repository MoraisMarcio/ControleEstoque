using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Produto
    {
        // PROPRIEDADES
        [Key]
        public int ProdutoId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Unidade { get; set; }

        [Required]
        public decimal PrecoCusto { get; set; }

        [Required]
        public decimal PrecoVenda { get; set; }

        [Required]
        public float EmEstoque { get; set; }

        // RELACIONAMENTO

    }
}
