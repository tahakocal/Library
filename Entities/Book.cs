using System.ComponentModel.DataAnnotations;

namespace Library.Entities
{
    public class Book : BaseEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string Description { get; set; }

        public bool Rented { get; set; }
    }
}
