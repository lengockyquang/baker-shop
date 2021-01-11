using System;
using System.Collections.Generic;

namespace BakerShopApp.Models
{
    public partial class UserRoles
    {
        public UserRoles()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Locale { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
