using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class Recebimento
    {
        // PROPRIEDADES
        [Key]
        public int RecebimentoId { get; set; }

        [Required]
        public DateTime DataVencimento { get; set; }

        [Required]
        public decimal Valor { get; set; }

        // Chave Estrangeira
        public int VendaId { get; set; }

        // RELACIONAMENTO       
        public virtual Venda _Vendas { get; set; }
    }
}
