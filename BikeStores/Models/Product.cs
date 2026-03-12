using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStores
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = null!;

        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public short ModelYear { get; set; }

        public decimal ListPrice { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public ICollection<Stock> Stocks { get; set; } = new List<Stock>();
    }
}
