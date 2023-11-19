using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? Address { get; set; }
        public string? Email {  get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? CelPhone { get; set; }
        public virtual ICollection<Order>? Order { get; set; }
    }
}
