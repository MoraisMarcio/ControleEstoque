using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Venda
    {
        // PROPRIEDADES
        [Key]
        public int VendaId { get; set; }

        [Required]
        public DateTime Data { get; set; }
        public decimal PrecoTotal { get; set; }

        // Chave Estrangeira
        public int ItemProdutoId { get; set; }
        public int ClienteId { get; set; }

        // RELACIONAMENTO
        public virtual ICollection<ItemSaida> _ItemSaidas { get; set; }
        public virtual Cliente _Clientes { get; set; }
        public virtual Recebimento _Recebimentos { get; set; }
    }
}
