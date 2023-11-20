using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class OrderHistory
    {
        public Guid OrderHistoryId { get; set; }
        public ulong OrderId { get; set; }//fk
        public Guid TransactionId { get; set; }
        public string? ProductId { get; set; }
        public int QuantityProduct { get; set; }
    }
}
