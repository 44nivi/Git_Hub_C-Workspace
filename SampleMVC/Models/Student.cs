using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace SampleMVC.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [NotNull]
        public string Name { get; set; }

        [Required]
        [NotNull]
        public string Description { get; set; }
        [Required]
        [NotNull]
        public string Phone { get; set; }
        [Required]
        [NotNull]
        public string Email { get; set; }

    }
}
