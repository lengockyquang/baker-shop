using BakerShopApp.Models;
using System;
using System.Collections.Generic;

namespace TodoApp.Models
{
    public partial class Groups
    {
        public Groups()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
