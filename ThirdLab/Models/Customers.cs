using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThirdLab.Models
{
    public class Customers
    {
        [Key]
        public int Id_Customer { get; set; }
        public string Name { get; set; }
    }
}