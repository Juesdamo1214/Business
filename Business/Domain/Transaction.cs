namespace Domain
{
    public class Transaction
    {
        public Guid TransactionId { get; set; }          
        public string? ProductId { get; set; }//fk
        public int QuantityProduct { get; set; }        
    }
}
