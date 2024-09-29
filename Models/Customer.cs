using System.ComponentModel.DataAnnotations;

namespace ManagingRestaurant.Models
{
    public class Customer
    {
        public Customer()
        {
            Comments = new HashSet<Comment>();
            DishReviews = new HashSet<DishReview>();
            Reservations = new HashSet<Reservation>();
            Orders = new HashSet<Order>();
        }

        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public virtual AppUser? AppUser { get; set; }
        public virtual ICollection<Comment>? Comments { get; set; }
        public virtual ICollection<DishReview>? DishReviews { get; set; }
        public virtual ICollection<Reservation>? Reservations { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
    }
}
