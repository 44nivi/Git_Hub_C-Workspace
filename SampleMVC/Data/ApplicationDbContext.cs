using Microsoft.EntityFrameworkCore;
using SampleMVC.Models;

namespace SampleMVC.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }

        public DbSet<Student> Students{  get; set; }

    }
}
