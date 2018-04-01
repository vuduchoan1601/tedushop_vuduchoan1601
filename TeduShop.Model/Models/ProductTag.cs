using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { set; get; }

        [Key]
        [Required]
        [MaxLength(10)]
        [Column(TypeName ="varchar")]
        public string TagID { set; get; }
    }
}