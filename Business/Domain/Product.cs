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
        public string? ProductGroupId { get; set; }//fk
        public Guid PriceProductHistoryId { get; set; }//fk
        public DateTime ProductCreationDate { get; set; }  
        public float PriceWithoutTaxes { get; set; }        
        public float Price { get; set; }
        
    }
}
