using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PHARAM.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }
        public DbSet<Pharmacie> Pharmacies { get; set; }
    }
}