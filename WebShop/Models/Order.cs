using System;
using System.Collections.Generic;

#nullable disable

namespace WebShop.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? Shipdate { get; set; }
        public int? TransactStatusId { get; set; }
        public bool Deleted { get; set; }
        public bool Paid { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? PaymentId { get; set; }
        public string Note { get; set; }
        public string Address { get; set; }
        public int? LocationId { get; set; }
        public int? District { get; set; }
        public string Ward { get; set; }
        public double? TotalMoney { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual TransactStatus TransactStatus { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
