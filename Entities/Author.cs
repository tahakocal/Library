using System.ComponentModel.DataAnnotations;

namespace Library.Entities
{
    public class Author : BaseEntity
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(32)]
        public string Name { get; set; }

        [Required]
        [StringLength(32)]
        public string Surname { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}