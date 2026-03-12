using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStores
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = null!;

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
