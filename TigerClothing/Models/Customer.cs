using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TigerClothing.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; } 
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public int Email { get; set; }
        public int PhoneNumber { get; set; }
    }
}
