using CommandCenter.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
