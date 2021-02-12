using System;

namespace Data.Entity
{
    public interface IEntity
    {
        public Guid? ID { get; set; }
    }
}
