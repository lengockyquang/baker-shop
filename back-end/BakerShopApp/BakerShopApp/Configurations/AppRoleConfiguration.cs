using BakerShopApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakerShopApp.Configurations
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("AppRoles");
            builder.Property(x => x.Description).HasMaxLength(200).IsRequired();
        }
    }
}
