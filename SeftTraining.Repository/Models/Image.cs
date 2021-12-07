using System;
using System.Collections.Generic;

#nullable disable

namespace SeftTraining.Data.Models
{
    public partial class Image
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int? ProductId { get; set; }
        public int Status { get; set; }

        public virtual Product Product { get; set; }
    }
}
