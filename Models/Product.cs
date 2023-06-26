using System;
using System.Collections.Generic;

namespace NewApplication.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderItems = new HashSet<OrderItem>();
            Stocks = new HashSet<Stock>();
        }

        public string ProductId { get; set; } = null!;
        public string? ProductName { get; set; }
        public string? BrandId { get; set; }
        public string? CategoryId { get; set; }
        public int? ModelYear { get; set; }
        public long? ListPrice { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
