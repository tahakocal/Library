namespace LibraryAutomation.Entities
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

        public bool Rented { get; set; } = false;

        public int PublisherId { get; set; }

        public virtual Publisher Publisher { get; set; }




        public int ShelveId { get; set; }

        public virtual Shelve Shelve { get; set; }


       

        public int HallId { get; set; }

        public virtual Hall Hall { get; set; }



        public int CabinetId { get; set; }

        public virtual Cabinet Cabinet { get; set; }


    }
}
