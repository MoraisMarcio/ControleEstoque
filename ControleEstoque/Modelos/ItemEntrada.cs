using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ItemEntrada
    {
        // PROPRIEDADES
        public int ItemEntradaId { get; set; }

        [Required]
        public decimal PrecoUnitario { get; set; }

        [Required]
        public float Quantidade { get; set; }

        // Chave Estrangeira
        public int ProdutoId { get; set; }
        
        // RELACIONAMENTO

    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  