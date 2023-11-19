using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ProductGroup
    {
        public Guid ProductGroupId { get; set; }
        public Guid TaxId { get; set; }//fk        
        public virtual Tax? Tax { get; set; }
        public virtual ICollection<Product>? Product { get; set; }
    }
}
