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
        public string NomeCliente { get; set; }

        // RELACIONAMENTO
    }
}
