using Mvc_sample_Project_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_sample_Project_2
{
    public class RandomViewModel
    {
        public Movie Movie{ get; set; }
        public List<Customers> Customers { get; set;}
    }
}