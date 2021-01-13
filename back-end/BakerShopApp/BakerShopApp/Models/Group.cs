using BakerShopApp.Models;
using System;
using System.Collections.Generic;

namespace TodoApp.Models
{
    public partial class Group
    {
        public Group()
        {
            Product = new HashSet<Product>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
