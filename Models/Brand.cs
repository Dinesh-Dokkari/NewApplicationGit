using System;
using System.Collections.Generic;

namespace NewApplication.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        public string BrandId { get; set; } = null!;
        public string? BrandName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
