using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Produto
    {
        // PROPRIEDADES

        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        public string Unidade { get; set; }

        public decimal ValorReferencia { get; set; }

        public decimal ValorVenda { get; set; }

        public float SaldoAtual { get; set; }

        // RELACIONAMENTO

    }
}
