using System.ComponentModel.DataAnnotations;

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

        public Course ()
        {
            Name = string.Empty;
            ShortDescripcion = string.Empty;
            LargeDescription = string.Empty;
            TargetAudiences = string.Empty;
            Goals = string.Empty;
            Requirements = string.Empty;
        }
    }

    public enum Level
    {
        Basic,
        Intermediate,
        Advance
    }
}
