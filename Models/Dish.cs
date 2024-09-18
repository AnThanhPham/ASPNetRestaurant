using System.ComponentModel.DataAnnotations.Schema;

namespace ManagingRestaurant.Models
{
    public class Dish
    {
        public Dish()
        {
            DishReviews = new HashSet<DishReview>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        public string Description { get; set; }

        public double Price { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        public string Image {  get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        public string ShortDesc { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<DishReview> DishReviews { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
