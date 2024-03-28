using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bushra.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public required int OrderHeaderId { get; set; }
        public OrderHeader? OrderHeader { get; set; }
        public required int ProductId { get; set; }
        public Product? Product { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

    }
}
