using System;
using System.Collections.Generic;

namespace BakerShopApp.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool Enabled { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Decription { get; set; }
        public int UserRoleId { get; set; }

        public virtual UserRoles UserRole { get; set; }
    }
}
