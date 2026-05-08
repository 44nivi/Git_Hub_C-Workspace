using Mvc_sample_Project_2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc_sample_Project_2.Context
{
    public class Customerdb_context : DbContext
    {
        public Customerdb_context() : base("Customerdb_context") { }

        public DbSet<Customers> Customers { get; set; }

        
    }
   

}