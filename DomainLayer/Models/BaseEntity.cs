

using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
   public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string? CreatedDate { get; set; } 
        public string? ModifiedDate { get; set; }
        public Nullable<bool> IsActive { get; set; } = true;
    }
}
