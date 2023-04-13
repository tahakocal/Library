using System;

namespace LibraryAutomation.Entities
{

    public enum State
    {
        HAZIR,
        KİRALANDI,
        ARŞİVDE
    }

    public class RentBook : BaseEntity
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public virtual Book Book { get; set; }

        public int MemberId { get; set; }

        public virtual Member Member { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public State State { get; set; }

    }
}