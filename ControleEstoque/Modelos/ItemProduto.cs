using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ItemProduto
    {
        // PROPRIEDADES
        public int ItemProdutoId { get; set; }

        [Required]
        public decimal ItemProduto_Preco { get; set; }

        [Required]
        public float ItemProduto_Quantidade { get; set; }

        // Chave Estrangeira
        public int ProdutoId { get; set; }
        
        // RELACIONAMENTO

    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  