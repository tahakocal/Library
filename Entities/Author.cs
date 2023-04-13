using System.Collections.Generic;

namespace LibraryAutomation.Entities
{
    public class Author : BaseEntity
    {
        public int Id { get; set; }

        public string AuthorName { get; set; }

        public string AuthorSurname { get; set; }

        public string AuthorDescription { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}