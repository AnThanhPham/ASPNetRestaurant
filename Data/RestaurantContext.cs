using ManagingRestaurant.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ManagingRestaurant.Data
{
    public class RestaurantContext : IdentityDbContext<AppUser>
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options) { }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Page> Pages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            // Bỏ tiền tố AspNet của các bảng: mặc định
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }

            modelBuilder.Entity<Blog>().ToTable(nameof(Blog));
            modelBuilder.Entity<Page>().ToTable(nameof(Page));
        }
    }
}
