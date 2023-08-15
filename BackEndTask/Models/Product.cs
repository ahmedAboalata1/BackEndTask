using System.ComponentModel.DataAnnotations;

namespace BackEndTask.Models
{
    public class Product
    {
        public int Id { set; get; }
        [Required]
        [MinLength(3, ErrorMessage = "Product name is required and must be at least 3 characters long")]
        public string Name { set; get; }
        [MaxLength(500, ErrorMessage = "Product description cannot exceed 500 characters.")]
        public string? Description { set; get; }
        [Required(ErrorMessage = "Product price is required and must be at least 0.01.")]
        [Range(0.01,double.MaxValue, ErrorMessage = "Product price must be at least 0.01.")]
        public decimal Price { set; get; }
        [Required]
        [Range(0,int.MaxValue,ErrorMessage = "Stock quantity is required and must be a non-negative value.")]
        public int StockQuantity { set; get; }

        public DateTime CreatedDate { set; get; }

    }
}
