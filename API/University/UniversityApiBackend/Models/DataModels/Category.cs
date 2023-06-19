using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }


        public Category() {
            Courses = new List<Course>();
        }
    }
}
