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
        public Guid ProductGroupId { get; set; }//fk
        public Guid PriceProductHistoryId { get; set; }//fk
        public DateTime ProductCreationDate { get; set; }  
        public float PriceWithoutTaxes { get; set; }        
        public float Price { get; set; }
        public int StockHistory { get; set; }

    }
}
