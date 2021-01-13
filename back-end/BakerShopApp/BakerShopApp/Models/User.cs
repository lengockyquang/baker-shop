using System;
using System.Collections.Generic;

namespace BakerShopApp.Models
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
