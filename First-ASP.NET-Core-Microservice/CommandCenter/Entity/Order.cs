namespace CommandCenter.Entity
{
    public class Order : IEntity
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public int Quantity { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
