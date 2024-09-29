using System.ComponentModel.DataAnnotations;

namespace ManagingRestaurant.Models
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        public Guid Id { get; set; }
        public double TotalPrice { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Created_at { set; get; }

        [DataType(DataType.Date)]
        public DateTime? Updated_at { set; get; }

        public string? Status { get; set; }
        public virtual AppUser? AppUser { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual Payment? Payment { get; set; }
        public virtual Table? Table { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
