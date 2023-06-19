using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Chapters: BaseEntity
    {
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        [Required]
        public string List { get; set; }

        public Chapters()
        {
            List = string.Empty;
            Course = new Course();
        }
    }
}
