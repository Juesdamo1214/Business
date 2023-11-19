using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order
    {
        public int ConsecutivePurchaseNumberId { get; set; }
        public Guid TransactionId { get; set; }
        public DateTime DatePurchase { get; set; }
        public virtual ICollection<Product>? Product { get; set; }
    }
}
