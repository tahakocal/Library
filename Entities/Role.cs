using System.ComponentModel.DataAnnotations;

namespace Library.Entities
{
    public class Role : BaseEntity
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
    }
}
