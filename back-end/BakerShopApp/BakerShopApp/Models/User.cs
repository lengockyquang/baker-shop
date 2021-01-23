using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace BakerShopApp.Models
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }

    }
}
