using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TigerClothing.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderPlaced { get; set; }
        public int TotalSumOrder { get; set; }

        [ForeignKey("Customer")]
        public int FK_CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("Cart")]
        public int FK_CartId { get; set; }
        public virtual Cart Cart { get;set; }

    }
}
