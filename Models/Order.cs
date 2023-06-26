using System;
using System.Collections.Generic;

namespace NewApplication.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public string OrderId { get; set; } = null!;
        public string? CustomerId { get; set; }
        public string? OrderStatus { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string? StoreId { get; set; }
        public string? StaffId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Staff? Staff { get; set; }
        public virtual Store? Store { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
