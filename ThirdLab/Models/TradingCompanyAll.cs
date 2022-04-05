using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ThirdLab.Models
{
    public class TradingCompanyAll : DbContext
    {
        public DbSet <Customers> AllCustomers { get; set; }
        public DbSet<Orders> AllOrders { get; set; }
    }
}