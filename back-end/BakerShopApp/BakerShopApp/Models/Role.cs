using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace BakerShopApp.Models
{
    public class Role : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
