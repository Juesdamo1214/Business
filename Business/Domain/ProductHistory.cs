using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ProductHistory
    {
        public Guid ProductHistoryId { get; set; }
        public string? ProductId { get; set; }//fk
        public DateTime? PriceModificationDate { get; set; }
        public float Subtotal { get; set; }
        public float Tax { get; set; }
        public float Price { get; set; }
        public int StockHistory {  get; set; }
        public virtual Product? Product { get; set; }

    }
}
