using System.ComponentModel.DataAnnotations;

namespace Library.Entities
{
    public class Category : BaseEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}