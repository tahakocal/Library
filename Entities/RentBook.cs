using System.ComponentModel.DataAnnotations;

namespace Library.Entities
{

    public enum State
    {
        READY,
        RENTED,
        ARCHIVED
    }

    public class RentBook : BaseEntity
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public virtual Book Book { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public State State { get; set; }

    }
}