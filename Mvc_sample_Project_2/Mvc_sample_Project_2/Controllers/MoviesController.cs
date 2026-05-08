using Mvc_sample_Project_2.Context;
using Mvc_sample_Project_2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http.Validation;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Xml.Linq;

namespace Mvc_sample_Project_2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/random
        public ActionResult Customer_view()

        {

            var customers = new List<Customers>
            {
                new Customers{ Name="Nivek ",Id=1},
                new Customers{Name= "Praveen",Id=2}
            };

            var viewModel = new RandomViewModel
            {
                
                Customers = customers
            };

            return View(viewModel);
            //return Content("HELLO WORLD!!");
            // return HttpNotFound();
            //return new EmptyResult();
           // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }



        public ActionResult Customer_page(int Id, string Name)
        {
            var cust = new Customers()
            {
                Name = Name,
                Id=Id
            };

            return View(cust);
        }

      //  [Route("movies/released/{year}/{month:regex(\\d{4})}")]
        public ActionResult ByReleaseDate(int year,int month) {

            return Content(year + "/" + month);
        }
        
        public ActionResult Movies_List()
        {
            List<Movie> list =new List<Movie>()
            {
               new Movie(){ Name="gilli ",Id=1},
               new Movie(){Name="thupaki",Id=2},

            };
            ViewBag.model = list;
      
            return View();
        }
    public ActionResult Add()
        {

            return View();
        }
     [HttpPost]
     [ValidateAntiForgeryToken]

    public ActionResult AddCustomer([Bind(Include = "Name")] Customers customers)
        {
            using(Customerdb_context dbcontext = new Customerdb_context())
            {

                dbcontext.Customers.Add(customers);
                dbcontext.SaveChanges();

            }
            string message = "Created the record successfully";

            // To display the message on the screen
            // after the record is created successfully
            ViewBag.Message = message;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Addmovie([Bind(Include = "Name")] Movie movie)
        {
            using (moviedb_context _Context = new moviedb_context())
            {
                _Context.movies.Add(movie);
                _Context.SaveChanges();
                
            }
            string message = "Movie  record successfully";

            ViewBag.Message = message;
            return View();
        }

        public ActionResult Edit() { return View();  }

     public ActionResult Delete() { return View(); }
     

    }

    
}

