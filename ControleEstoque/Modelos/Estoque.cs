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
        public string Estoque_Nome { get; set; }

        // Chave Estrangeira
        public int ProdutoId { get; set; }

        // RELACIONAMENTO
    }
}
