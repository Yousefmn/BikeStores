using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStores
{
    public class Stock
    {
        public int StoreId { get; set; }
        public Store Store { get; set; } = null!;

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public int Quantity { get; set; }
    }
}
