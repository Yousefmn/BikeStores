using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStores
{
    public class Staff
    {
        public int StaffId { get; set; }

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;
        public string? Phone { get; set; }

        public bool Active { get; set; }

        public int StoreId { get; set; }
        public Store Store { get; set; } = null!;

        public int? ManagerId { get; set; }
        public Staff? Manager { get; set; }

        public ICollection<Staff> Subordinates { get; set; } = new List<Staff>();

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
