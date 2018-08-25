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
        public DateTime Data { get; set; }

        // Chave Estrangeira
        public int ItemProdutoId { get; set; }
        public int ClienteId { get; set; }

        // RELACIONAMENTO
    }
}
