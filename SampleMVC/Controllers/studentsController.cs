using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleMVC.Data;
using SampleMVC.Models;

namespace SampleMVC.Controllers
{   
    public class studentsController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public studentsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Addmore()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Hit(Add_Student_Model viewModel)
        {
            var student = new Student
            {
                Name = viewModel.Name,
                Description = viewModel.Description,
                Phone = viewModel.Phone,
                Email = viewModel.Email
            };
            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();
            var Info = "Successfully Details Added";
            return RedirectToAction("Addmore", "students");

        }

      /*  [HttpPost]
        public async Task <IActionResult> Add(Add_Student_Model viewModel)    
        {
            var student = new Student
            {
                Name = viewModel.Name,
                Description = viewModel.Description,
                Phone = viewModel.Phone,
                Email = viewModel.Email
            };
            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();
            var Info = "Successfully Details Added";
            return RedirectToAction("Addmore", "students");

        }
*/
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var students= await dbContext.Students.ToListAsync();

            return View(students);
        }

        [HttpGet]
        public async Task<IActionResult> Edit1(Guid id)
        {
            var students = await dbContext.Students.FindAsync(id);

            return View(students);
        }

        [HttpPost]
        public async Task<IActionResult> PostValue(string bsonData)
        {

            return View(new { success = true });
        }

        [HttpPost]
        public async Task<IActionResult> NewAjax()
        {

            return View(new { success = true });
        }
        [HttpPost]
        public async Task<IActionResult> Edit1(Student viewModel)
        {
            var students = await dbContext.Students.FindAsync(viewModel.Id);

            if(students is not null)
            {

                students.Name=viewModel.Name;
                students.Description=viewModel.Description;
                students.Phone=viewModel.Phone;
                students.Email=viewModel.Email;
            }
            await dbContext.SaveChangesAsync();

            return RedirectToAction("List","students");
        }


        [HttpPost]
        public async Task<IActionResult> Delete(Student viewModel)
        {
            var students = await dbContext.Students.AsNoTracking().FirstOrDefaultAsync(x=>x.Id==viewModel.Id);
            if (students is not null)
            {

                dbContext.Students.Remove(viewModel);
                await dbContext.SaveChangesAsync();

            }

            return RedirectToAction("List", "students");

        }
    }
}
