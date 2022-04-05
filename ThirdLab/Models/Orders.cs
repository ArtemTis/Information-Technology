using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThirdLab.Models
{
    public class Orders
    {
        [Key]
        public int Id_order { get; set; }
        public string Amount { get; set; }
    }
}