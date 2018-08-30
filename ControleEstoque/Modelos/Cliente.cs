using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Cliente
    {
        // PROPRIEDADES

        [Key]
        public int ClienteId { get; set; }

        [Required] 
        public string Nome { get; set; }

        [Required]
        [StringLength(9)]
        public string Telefone { get; set; } // CRIAR TABELA TELEFONE

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Endereco { get; set; }

        [Required]
        public string NumResidencial { get; set; }
        
        public string Cidade { get; set; }

        // RELACIONAMENTO
    }
}
