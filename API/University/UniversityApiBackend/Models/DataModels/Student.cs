using Humanizer;
using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Student : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime DateOfBirday { get; set; }


        public ICollection<Course> Courses { get; set; }

        public Student()
        {
            Name = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;

            Courses = new List<Course>();
        }
    }
}
