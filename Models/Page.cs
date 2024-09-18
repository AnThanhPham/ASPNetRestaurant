using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ManagingRestaurant.Models
{
    public class Page
    {
        public int Id { get; set; }

        public string name { get; set; }

        public string? image { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        public string ShortDesc { get; set; }


        [Column(TypeName = "NVARCHAR(MAX)")]
        public string Desciption { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Created_at { set; get; }

        [DataType(DataType.Date)]
        public DateTime? Update_at { set; get; }

        public virtual AppUser? AppUser { get; set; }
    }
}
