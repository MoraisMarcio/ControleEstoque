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
        public string Cliente_Nome { get; set; }

        [Required]
        [StringLength(9)]
        public string Cliente_Telefone { get; set; } // CRIAR TABELA TELEFONE

        [Required]
        public string Cliente_Bairro { get; set; }

        [Required]
        public string Cliente_Endereco { get; set; }

        [Required]
        public string Cliente_NumResidencial { get; set; }
        
        public string Cliente_Cidade { get; set; }

        // RELACIONAMENTO
    }
}
