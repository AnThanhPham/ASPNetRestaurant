using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagingRestaurant.Models
{
    public class Comment
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Created_at { set; get; }

        public virtual Blog? Blog {  get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
