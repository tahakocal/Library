﻿namespace LibraryAutomation.Entities
{
    public class Member : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int? BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
