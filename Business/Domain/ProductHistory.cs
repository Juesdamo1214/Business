using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ProductHistory
    {
        public Guid PriceProductHistoryId { get; set; }
        public string? ProductId { get; set; }
        public DateTime? PriceModificationDate { get; set; }
        public float PriceWithoutTaxes { get; set; }
        public float Tax { get; set; }
        public float Price { get; set; }
        public int StockHistory {  get; set; }

    }
}
