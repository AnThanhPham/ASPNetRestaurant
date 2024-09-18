namespace ManagingRestaurant.Models
{
    public enum StatusTable {
        available,reserved
    }

    public class Table
    {
        public Table()
        {
            Reservations = new HashSet<Reservation>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Table_Number { get; set; }
        public int Capacity { get; set; }

        public StatusTable? Status { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
