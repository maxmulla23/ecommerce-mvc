using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_mvc.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public int AppUserId { get; set; }
        public AppUser User { get; set; }

        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}