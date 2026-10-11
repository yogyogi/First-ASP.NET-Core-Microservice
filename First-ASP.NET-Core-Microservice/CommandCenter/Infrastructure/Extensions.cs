using CommandCenter.Entity;

namespace CommandCenter.Infrastructure
{
    public static class Extensions
    {
        public static OrderDto AsDto(this Order order)
        {
            return new OrderDto(order.Id, order.Address, order.Quantity, order.CreatedDate);
        }
    }
}
