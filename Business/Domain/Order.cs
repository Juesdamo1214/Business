namespace Domain
{
    public class Order
    {
        public ulong OrderId { get; set; }
        public Guid CustomerId { get; set; }//fk
        public DateTime OrderDate { get; set; }
        public float Subtotal { get; set; }
        public float TotalTax { get; set; }
        public float Total { get; set; }        
        public virtual Customer? Customer { get; set; }
        public virtual ICollection<Transaction>? Transaction { get; set; }
    }
}
