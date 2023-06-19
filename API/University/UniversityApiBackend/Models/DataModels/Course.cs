using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;

namespace UniversityApiBackend.Models.DataModels
{
    public class Course : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [StringLength(280)]
        public string ShortDescripcion { get; set; }
        public string LargeDescription { get; set; }
        public string TargetAudiences { get; set; }
        public string Goals { get; set; }
        public string Requirements { get; set; }
        public Level Level { get; set; }
        
        [Required]
        public Chapters Chapters { get; set; }
        

        [Required]
        public ICollection<Category> Categories { get; set; }
        [Required]
        public ICollection<Student> Students { get; set; }

        public Course ()
        {
            Name = string.Empty;
            ShortDescripcion = string.Empty;
            LargeDescription = string.Empty;
            TargetAudiences = string.Empty;
            Requirements = string.Empty;
            Goals = string.Empty;
            Chapters = new Chapters();
            Students= new List<Student>();
            Categories = new List<Category>();
        }
    }

    public enum Level
    {
        Basic,
        Intermediate,
        Advance,
        Expert
    }
}
