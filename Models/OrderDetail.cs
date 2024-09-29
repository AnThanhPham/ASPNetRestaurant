using System.ComponentModel.DataAnnotations;

namespace ManagingRestaurant.Models
{
    public class OrderDetail
    {
        [Key]
        public Guid Id { get; set; }
        public int? Quantity { get; set; }
        public decimal? Unit_price { get; set; }
        public virtual Order? Order { get; set; }
        public virtual Dish? Dish { get; set; }
    }
}
