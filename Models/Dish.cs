using System.ComponentModel.DataAnnotations;
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

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public double Price { get; set; }

        [Column(TypeName = "ntext")]
        [Display(Name = "Image")]
        public string? Image {  get; set; }

        [Column(TypeName = "ntext")]
        public string ShortDesc { get; set; }

        public bool IsActive { get; set; }

        [Required]
        public virtual Category? Category { get; set; }
        public virtual ICollection<DishReview>? DishReviews { get; set; }
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
