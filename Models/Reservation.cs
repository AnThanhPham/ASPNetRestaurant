using System.ComponentModel.DataAnnotations;

namespace ManagingRestaurant.Models
{
    public class Reservation
    {
        [Key]
        public Guid Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Reservation_Time { set; get; }

        public string? Status { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Created_at { set; get; }

        [DataType(DataType.Date)]
        public DateTime? Updated_at { set; get; }
        public virtual Customer? Customer { get; set; }
        public virtual Table? Table { get; set; }
    }
}
