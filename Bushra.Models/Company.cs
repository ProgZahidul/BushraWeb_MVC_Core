﻿
namespace Bushra.Models
{
    public class Company
    {
        public int Id { get; set; }
      
        public required string Name { get; set; }
        public string? Address { get; set; }
        public string? Country { get; set; }
        public string? PostalCode { get; set; }
        public string? PhoneNumber { get; set; }
    }
}