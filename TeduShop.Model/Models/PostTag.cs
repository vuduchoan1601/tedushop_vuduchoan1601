using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostID { set; get; }

        [Key]
        [Required]
        [MaxLength(10)]
        [Column(TypeName = "varchar")]
        public string TagID { set; get; }
    }
}