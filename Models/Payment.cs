using System.ComponentModel.DataAnnotations;

namespace ManagingRestaurant.Models
{
    public class Payment
    {
        public Payment()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Order>? Orders { get; set; }
    }
}
