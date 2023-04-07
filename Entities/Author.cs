using System.ComponentModel.DataAnnotations;

namespace Library.Entities
{
    public class Author : BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}