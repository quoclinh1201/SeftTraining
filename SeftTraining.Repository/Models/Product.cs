using System;
using System.Collections.Generic;

#nullable disable

namespace SeftTraining.Data.Models
{
    public partial class Product
    {
        public Product()
        {
            Images = new HashSet<Image>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Category { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int Status { get; set; }

        public virtual Category CategoryNavigation { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}
