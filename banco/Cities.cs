using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBRQ.banco
{
    public class Cities
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        
        public int cod_states { get; set; }

    }
}


