using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBRQ.banco
{
    public class Products
    {
        [Key]
        public int Id { get; set; }

        public string Car_name { get; set; }

        public string Car_description { get; set; }

        public float Value_cust { get; set; }

        public float Value_price { get; set; }

        public DateTime Warranty { get; set; }

        public string Motor_type { get; set; }

        public string Car_type { get; set; }


    }
}



