using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T.Core
{
    public abstract class Entity : Entity<int>
    {
    }

    public abstract class Entity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
    }
}
