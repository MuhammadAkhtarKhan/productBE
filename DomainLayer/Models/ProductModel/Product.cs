using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models.ProductModel
{
    public class Product : BaseEntity
    {
        

        [Required(ErrorMessage = "Product name is required")]
        [StringLength(50, ErrorMessage = "Product name cannot be longer than 50 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Product description is required")]
        [StringLength(100, ErrorMessage = "Product description cannot be longer than 100 characters")]
        public string Description { get; set; } = string.Empty;

        [ForeignKey(nameof(ProductCategoryId))]
        public int? ProductCategoryId { get; set; }
    }
    public class ProductCategory
    {
        [Key]
        public int ProductCategoryId { get; set; }

        [Required(ErrorMessage = "Category name is required")]
        [StringLength(50, ErrorMessage = "Category name cannot be longer than 50 characters")]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
