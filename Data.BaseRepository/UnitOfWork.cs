using Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.BaseRepository
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class, IEntity
    {
        private readonly GvResourceContext context;
        public UnitOfWork(GvResourceContext context)
        {
            this.context = context;
            Repository = new Repository<T>(context);

        }
        public IRepository<T> Repository { get; }

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
