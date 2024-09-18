namespace ManagingRestaurant.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Unit_price { get; set; }
        public virtual Order? Order { get; set; }
        public virtual Dish? Dish { get; set; }
    }
}
