using System;
using System.Collections.Generic;

namespace NewApplication.Models
{
    public partial class Store
    {
        public Store()
        {
            Orders = new HashSet<Order>();
            Stocks = new HashSet<Stock>();
            staff = new HashSet<Staff>();
        }

        public string StoreId { get; set; } = null!;
        public string? StoreName { get; set; }
        public long? Phone { get; set; }
        public string? Email { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public long? ZipCode { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
        public virtual ICollection<Staff> staff { get; set; }
    }
}
