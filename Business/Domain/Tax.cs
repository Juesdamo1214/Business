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
        public string? ProductId { get; set; }
        public float Tax05 { get; set; }
        public float Tax19 { get; set;}
        public virtual Product? Product { get; set; }
    }
}
