using BakerShopApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakerShopApp.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Dob).IsRequired();

        }
    }
}
