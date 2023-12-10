using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.DTOs
{
    public class UpdateProductDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public Nullable<bool> IsActive { get; set; } = true;
        public int? ProductCategoryId { get; set; }
        public string? ModifiedDate { get; set; }
    
    }
}
