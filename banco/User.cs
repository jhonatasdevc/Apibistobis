using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ApiBRQ.banco
{
    public class User
    {
        [Key]
        public int User_id { get; set; }

        public string User_name { get; set; }
        public string User_password { get; set; }
        public string User_email { get; set; }

        public DateTime User_registrade { get; set; }

        public int User_active { get; set; }
    }
}


