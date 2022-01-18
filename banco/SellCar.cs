using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBRQ.banco
{
    public class SellCar
    {
        [Key]
        public int Id { get; set;}

        public string Color { get; set; }

        public int Amount {get; set;}

        public DateTime Date_buy { get; set; }

        public Boolean Delivery { get; set; }

        public int Code_products { get; set; }

        public int Code_client { get; set; }

        public string Date_maintenance { get; set; }

        public string Km_traveled { get; set; }

        public int Code_city { get; set; }
    }
}
