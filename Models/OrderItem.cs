using System;
using System.Collections.Generic;

namespace NewApplication.Models
{
    public partial class OrderItem
    {
        public string OrderId { get; set; } = null!;
        public string ItemId { get; set; } = null!;
        public string? ProductId { get; set; }
        public long? Quantity { get; set; }
        public long? ListPrice { get; set; }
        public long? Discount { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Product? Product { get; set; }
    }
}
