using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStores.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public string? Phone { get; set; }
        public string Email { get; set; } = null!;

        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
