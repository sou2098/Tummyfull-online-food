
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Tummyfull.Models
{
    public class Menu_Card
    {
        [Key]
        public int Item_Code { get; set; }
        [Required]
        public string Item_Name { get; set; }
        [Required]
        public int Item_Price { get; set; }
    }
}
