using Mvc_sample_Project_2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;  
using System.Web;

namespace Mvc_sample_Project_2.Context
{
    public class moviedb_context : DbContext
    {
        public moviedb_context() : base("moviedb_context") { }

        public DbSet<Movie> movies { get; set; }
    }
}