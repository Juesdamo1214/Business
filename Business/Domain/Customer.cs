namespace Domain
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public DateTime CreateDate { get; set; }
        public string? Address { get; set; }
        public string? Email {  get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? CellPhone { get; set; }
        public virtual ICollection<Order>? Order { get; set; }
    }
}
