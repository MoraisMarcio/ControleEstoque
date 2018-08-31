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

        [Required]
        public DateTime Data { get; set; }
        public decimal PrecoTotal { get; set; }

        // Chave Estrangeira
        public int ItemProdutoId { get; set; }
        public int FornecedorId { get; set; }

        // RELACIONAMENTO
        public virtual ICollection<ItemEntrada> _ItemEntradas { get; set; }
        public virtual Fornecedor _Fornecedores { get; set; }
    }
}
