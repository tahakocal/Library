using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryAutomation.Entities
{
    public class BaseEntity
    {
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}