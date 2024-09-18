using System.ComponentModel.DataAnnotations.Schema;

namespace ManagingRestaurant.Models
{
    public class Category
    {
        public Category()
        {
            Dishes = new HashSet<Dish>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        public string Description { get; set; }

        public int Status { get; set; } // 1 là vẫn dùng, 2 là không dùng
        public virtual ICollection<Dish> Dishes { get; set; }
    }
}
