using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order
    {
        public ulong OrderId { get; set; }
        public Guid CustomerId { get; set; }//fk
        public DateTime OrderDate { get; set; }
        public float Subtotal { get; set; }
        public float totalTax { get; set; }
        public float Total { get; set; }        
        public virtual Customer? Customer { get; set; }
        public virtual ICollection<Transaction>? Transaction { get; set; }
        public virtual ICollection<OrderHistory>? OrderHistory { get; set; }
    }
}
