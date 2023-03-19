using System.ComponentModel.DataAnnotations;

namespace Library.Entities
{
    public class BaseEntity
    {
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}