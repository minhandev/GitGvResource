using Data.Entity;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.BaseRepository
{
    public class UnitOfWork : IUnitOfWork 
    {
        private readonly GvResourceContext context;
        public UnitOfWork(GvResourceContext context)
        {
            this.context = context;
            Employee = new Repository<Employee>(context);
        }
        public IRepository<Employee> Employee { get; }

        public async Task Commit()
        {
            await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
