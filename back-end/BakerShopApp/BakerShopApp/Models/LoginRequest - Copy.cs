using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace BakerShopApp.Models
{
    public class LoginRequest
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
