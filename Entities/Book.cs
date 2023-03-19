using System.ComponentModel.DataAnnotations;

namespace Library.Entities
{
    public class Book : BaseEntity
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Title { get; set; }

        public long AuthorId { get; set; }

        public virtual Author Author { get; set; }

        public long CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string Description { get; set; }

        public virtual ICollection<BookRating> BookRatings { get; set; }

        public bool Rented { get; set; }

        public string CoverURL { get; set; }

        public string ResizedCoverURL { get; set; }
    }
}
