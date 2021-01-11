using System;
using System.Collections.Generic;
using TodoApp.Models;

namespace BakerShopApp.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }

        public virtual Groups Group { get; set; }
    }
}
