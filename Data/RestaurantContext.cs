using ManagingRestaurant.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ManagingRestaurant.Data
{
    public class RestaurantContext : IdentityDbContext<AppUser>
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options) { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishReview> DishReviews { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Table> Tables { get; set; }

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

            /*modelBuilder.Entity<Blog>().ToTable(nameof(Blog));
            modelBuilder.Entity<Page>().ToTable(nameof(Page));
            modelBuilder.Entity<Category>().ToTable(nameof(Category));
            modelBuilder.Entity<Comment>().ToTable(nameof(Comment));
            modelBuilder.Entity<Customer>().ToTable(nameof(Customer));
            modelBuilder.Entity<Dish>().ToTable(nameof(Dish));
            modelBuilder.Entity<DishReview>().ToTable(nameof(DishReview));
            modelBuilder.Entity<Order>().ToTable(nameof(Order));
            modelBuilder.Entity<OrderDetail>().ToTable(nameof(OrderDetail));
            modelBuilder.Entity<Payment>().ToTable(nameof(Payment));
            modelBuilder.Entity<Reservation>().ToTable(nameof(Reservation));
            modelBuilder.Entity<Table>().ToTable(nameof(Table));*/
        }
    }
}
