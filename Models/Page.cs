using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ManagingRestaurant.Models
{
    public class Page
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string? Image { get; set; }

        [Column(TypeName = "ntext")]
        public string ShortDesc { get; set; }


        [Column(TypeName = "ntext")]
        public string Desciption { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Created_at { set; get; }

        [DataType(DataType.Date)]
        public DateTime? Update_at { set; get; }

        public virtual AppUser? AppUser { get; set; }
    }
}
