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
        public string Produto_Nome { get; set; }

        [Required]
        public string Produto_Unidade { get; set; }

        [Required]
        public decimal Produto_PrecoCusto { get; set; }

        [Required]
        public decimal Produto_PrecoVenda { get; set; }

        [Required]
        public float Produto_SaldoAtual { get; set; }

        // RELACIONAMENTO

    }
}
