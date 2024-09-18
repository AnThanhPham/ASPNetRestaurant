using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagingRestaurant.Models
{
    public class DishReview
    {
        public int Id { get; set; }
        public int Rating { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        public string comment { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Created_at { set; get; }

        public virtual Customer? Customer { get; set; }
        public virtual Dish? Dish { get; set; }
    }
}
