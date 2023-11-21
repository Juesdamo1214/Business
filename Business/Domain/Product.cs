using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public string? ProductId { get; set; }
        public Guid TaxId { get; set; }//fk
        public DateTime ProductCreationDate { get; set; }
        public float Subtotal { get; set; }
        public float Price { get; set; }
        public int StockHistory { get; set; }
        public virtual ICollection<ProductHistory>? ProductHistory { get; set; }
        public virtual Tax? Tax { get; set; }
    }
}
