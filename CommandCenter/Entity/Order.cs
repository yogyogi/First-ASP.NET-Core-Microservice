using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
