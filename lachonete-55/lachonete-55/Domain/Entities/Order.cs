namespace lanchonete_55.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public Status Status { get; set; }
    }

    public enum Status
    {
        Received,
        Preparing,
        Ready,
        Done
    }
}
