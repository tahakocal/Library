using System.ComponentModel.DataAnnotations;

namespace Library.Entities
{
    public class Role : BaseEntity
    {
        public long Id { get; set; }

        [Required]
        [StringLength(32)]
        public string Name { get; set; }
    }
}
