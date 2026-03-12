using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStores
{
    public class Store
    {
        public int StoreId { get; set; }

        public string StoreName { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Email { get; set; }

        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }

        public ICollection<Staff> Staffs { get; set; } = new List<Staff>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Stock> Stocks { get; set; } = new List<Stock>();
    }
}
