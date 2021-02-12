using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entity
{
    public abstract class BaseEntity : IEntity
    {
        public BaseEntity()
        {
            ID = Guid.NewGuid();
        }
        public Guid? ID { get; set; }
    }
}
