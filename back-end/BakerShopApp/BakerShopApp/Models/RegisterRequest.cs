using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BakerShopApp.Models
{
    public class RegisterRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

    }
}
