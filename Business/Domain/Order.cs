using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order
    {
        public int OrderId { get; set; }
        public ICollection<Transaction>? Transaction { get; set; }
        public DateTime OrderDate { get; set; }
        public float Subtotal { get; set; }
        public float totalTax { get; set; }
        public float Total { get; set; }
        public virtual ICollection<Transaction>? Transaction { get; set; }
    }
}
