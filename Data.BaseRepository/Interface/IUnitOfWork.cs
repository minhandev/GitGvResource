using Data.Entity;
using System;
using System.Threading.Tasks;

namespace Data.BaseRepository
{
    public interface IUnitOfWork<T> : IDisposable where T : class, IEntity
    {
        IRepository<T> Repository { get; }
        Task Commit();
    }
}
