namespace Library.Entities
{
    public class Employee : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? SectionId { get; set; }
        public virtual Section Section { get; set; }
    }
}