

namespace DomainLayer.Models
{
   public class BaseEntity
    {
        public string? CreatedDate { get; set; } 
        public string? ModifiedDate { get; set; }
        public Nullable<bool> IsActive { get; set; } = true;
    }
}
