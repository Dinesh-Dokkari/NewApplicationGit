using System;
using System.Collections.Generic;

namespace NewApplication.Models
{
    public partial class Staff
    {
        public Staff()
        {
            Orders = new HashSet<Order>();
        }

        public string StaffId { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Active { get; set; }
        public string? StoreId { get; set; }
        public string? ManagerId { get; set; }

        public virtual Store? Store { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
