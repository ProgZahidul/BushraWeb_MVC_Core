using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Bushra.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        [DisplayName("Category Name")]
        public required string Name { get; set; }
    }
}