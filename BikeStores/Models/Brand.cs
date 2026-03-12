using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStores
{
    public class Brand
    {
        public int BrandId { get; set; }

        public string BrandName { get; set; } = null!;

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
