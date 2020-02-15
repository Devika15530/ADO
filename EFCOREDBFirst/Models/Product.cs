using System;
using System.Collections.Generic;

namespace EFCOREDBFirst.Models
{
    public partial class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public int? Stock { get; set; }
    }
}
