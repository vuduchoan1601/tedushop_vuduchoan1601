using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("OrderDetals")]
    public class OrderDetal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { set; get; }

        [Key]
        public int ProductID { set; get; }

        public int Quantity { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Oder { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }
    }
}