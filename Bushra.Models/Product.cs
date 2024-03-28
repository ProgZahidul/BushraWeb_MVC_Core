using System.ComponentModel.DataAnnotations;

namespace Bushra.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<ProductImage>? ProductImages { get; set; }
    }
}
