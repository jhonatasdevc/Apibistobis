using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBRQ.banco
{
    public class Clients
    {
        [Key]
        public int Volvo_id { get; set; }

        public string Name { get; set; }

        public int Client_city { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
