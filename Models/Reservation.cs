using System.ComponentModel.DataAnnotations;

namespace ManagingRestaurant.Models
{
    public enum StatusReservation
    {
        pending,confirmed,cancelled
    }

    public class Reservation
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Reservation_Time { set; get; }

        public StatusReservation? Status { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Created_at { set; get; }

        [DataType(DataType.Date)]
        public DateTime? Updated_at { set; get; }
        public virtual Customer? Customer { get; set; }
        public virtual Table? Table { get; set; }
    }
}
