namespace Domain
{
    public class Transaction
    {
        public Guid TransactionId { get; set; }
        public ulong OrderId { get; set; }//fk
        public string? ProductId { get; set; }//fk
        public int QuantityProduct { get; set; }  
        public virtual Product? Product { get; set; }
        public virtual Order? Order { get; set; }
    }
}
