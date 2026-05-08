using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc_sample_Project_2.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
       public string Name { get; set; }


    }
}