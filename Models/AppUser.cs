using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ManagingRestaurant.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Blogs = new HashSet<Blog>();
            Pages = new HashSet<Page>();
            Customers = new HashSet<Customer>();
            Orders = new HashSet<Order>();
        }

        public int Status;

        [MaxLength(100)]
        public string FullName { set; get; }

        [MaxLength(255)]
        public string Address { set; get; }

        [DataType(DataType.Date)]
        public DateTime? Birthday { set; get; }

        [DataType(DataType.Date)]
        public DateTime? Created_at { set; get; }

        [MaxLength(255)]
        public string? Created_by { set; get; }

        [DataType(DataType.Date)]
        public DateTime? Update_at { set; get; }

        [MaxLength(255)]
        public string? Update_by { set; get; }

        public virtual ICollection<Blog> Blogs { get; set; }
        public virtual ICollection<Page> Pages { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
