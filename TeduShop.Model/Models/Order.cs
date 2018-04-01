using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(250)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(250)]
        public string CustomerEmail { set; get; }

        [Required]
        [MaxLength(250)]
        public string CustomerMobile { set; get; }

        public string CustomerMessege { set; get; }

        public DateTime? CreateDate { set; get; }

        public string CreateBy { set; get; }

        public string PaymentMethod { set; get; }

        public string PaymentStatus { set; get; }

        public bool? Status { set; get; }

        public virtual IEnumerable<OrderDetal> OrderDetals { set; get; }
    }
}