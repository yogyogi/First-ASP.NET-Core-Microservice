using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandCenter.Entity
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
