using Data.Entity;
using Data.Model;
using System;
using System.Threading.Tasks;

namespace Data.BaseRepository
{
    public interface IUnitOfWork : IDisposable 
    {
        IRepository<Employee> Employee { get; }
        Task Commit();
    }
}
