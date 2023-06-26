using System;
using System.Collections.Generic;

namespace NewApplication.Models
{
    public partial class Stock
    {
        public string StoreId { get; set; } = null!;
        public string ProductId { get; set; } = null!;
        public long? Quantity { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual Store Store { get; set; } = null!;
    }
}
