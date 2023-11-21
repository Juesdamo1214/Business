using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Tax
    {
        public Guid TaxId { get; set; }
        public float TaxProduct { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}
