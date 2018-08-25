﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ItemProduto
    {
        // PROPRIEDADES

        public decimal Preco { get; set; }
        public float Quantidade { get; set; }

        // Chave Estrangeira
        public int ProdutoId { get; set; }
        public int CompraId { get; set; }

        // RELACIONAMENTO

    }
}
