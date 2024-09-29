using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagingRestaurant.Models
{
    public class Blog
    {
        public Blog()
        {
            Comments = new HashSet<Comment>();
        }

        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Image")]
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
        public virtual ICollection<Comment>? Comments { get; set; }
    }
}
