using System.ComponentModel.DataAnnotations;

namespace CommandCenter.Infrastructure
{
    public record OrderDto(Guid Id, string Address, int Quantity, DateTimeOffset CreatedDate);
    public record CreateOrderDto([Required] string Address, [Range(0, 1000)] int Quantity);
    public record UpdateOrderDto([Required] string Address, [Range(0, 1000)] int Quantity);
}