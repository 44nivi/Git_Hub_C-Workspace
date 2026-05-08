using Microsoft.AspNetCore.Mvc;
using MVC_project_New.Models;
using System.Diagnostics;

namespace MVC_project_New.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {

            return View();
        }

            [HttpGet]
            public IActionResult GetEmployee()
            {
                return View();
            }



        public IActionResult NewPoster()
        {
            return View();
        }


        public IActionResult Getter_UI()
        {
            return View();
        }
        /*  [HttpPost]
          public IActionResult GetEmployeeDetails(BusinessId viewModel)
          {

              var Id = viewModel.Id;

              ViewBag.Message = Id;

              return View();

          }*/
        public IActionResult Rprivacy()
        {
            return View();
        }

        public IActionResult Aprivacy()
        {
            return View();
        }

        public IActionResult SortingGuide()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}