using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    /// <summary>
    /// Clase que tiene los atributos que todas las clases va tener
    /// </summary>
    /// <return>Clase que tiene los atributos que todas las clases va tener</return>
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public bool IsDeleted { get; set; }

        public BaseEntity()
        {
            CreatedBy = string.Empty;
            UpdatedBy = string.Empty;
            DeletedBy = string.Empty;
            IsDeleted = false;
            CreatedAt = DateTime.Now;
        }
    }
}
