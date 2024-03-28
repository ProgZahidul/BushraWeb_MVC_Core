using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bushra.Models
{
    public class OrderHeader
    {
        public int Id { get; set; }
        public required string ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        public DateTime OrderDate { get; set; }
        public DateTime ShippingDate { get; set; }
        public double OrderTotal { get; set; }

        public string? OrderStatus { get; set; }
        public string? PaymentStatus { get; set; }
        public string? TrackingNumber { get; set; }
        public string? Carrier { get; set; }

        public DateTime PaymentDate { get; set; }
        public DateTime PaymentDueDate { get; set; }

        public string? SessionId { get; set; }
        public string? PaymentIntentId { get; set; }

       
        public required string PhoneNumber { get; set; }
      
        public required string Address { get; set; }
        public required string PostalCode { get; set; }
      
        public required string Name { get; set; }


    }
}