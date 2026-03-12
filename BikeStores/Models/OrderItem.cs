using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStores
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        public int ItemId { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public int Quantity { get; set; }

        public decimal ListPrice { get; set; }

        public decimal Discount { get; set; }
    }
}
