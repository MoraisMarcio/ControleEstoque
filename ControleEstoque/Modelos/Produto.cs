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
        public string Descricao { get; set; }

        [Required]
        public string Unidade { get; set; }

        [Required]
        public decimal PrecoCusto { get; set; }

        [Required]
        public decimal PrecoVenda { get; set; }

        [Required]
        public float EmEstoque { get; set; }

        // Chave Estrangeira
        public int EstoqueId { get; set; }

        // RELACIONAMENTO
        public virtual ICollection<ItemEntrada> _ItemEntradas { get; set; }
        public virtual ICollection<ItemSaida> _ItemSaidas { get; set; }
        public virtual Estoque _Estoques { get; set; }
    }
}
