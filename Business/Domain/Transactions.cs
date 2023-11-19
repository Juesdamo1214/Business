namespace Domain
{
    public class Transactions
    {
        public Guid TransactionId { get; set; }
        public float Subtotal { get; set; }
        public float totalTax { get; set; }
        public float Total { get; set; }

    }
}
