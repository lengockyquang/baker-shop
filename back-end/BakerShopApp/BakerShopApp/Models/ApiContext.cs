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

        public  DbSet<Group> Group { get; set; }
        public  DbSet<Product> Product { get; set; }
        public  DbSet<User> User { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Group_Id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Product_Id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Product_Group_Id_fk");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("User_Id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.UserName).IsRequired();
            });


        }


    }
}
