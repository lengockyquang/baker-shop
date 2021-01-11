using System;
using BakerShopApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TodoApp.Models
{
    public class ApiContext : DbContext
    {

        public ApiContext(DbContextOptions<ApiContext> options)
         : base(options)
        {
        }

        public DbSet<Groups> Groups { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<Users> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.GroupId);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.GroupId);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasIndex(e => e.UserRoleId);

                entity.Property(e => e.Decription).HasColumnName("decription");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserRoleId);
            });


        }


    }
}
