namespace PlatformDemoLibrary
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public double Amount { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}