using Data.Entity;
using Data.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.BaseRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext context;
        private IUnitOfWork unitOfWork;
        public UnitOfWork(GvResourceContext _context)
        {
            context = _context;
            #region Phân vùng IRepository theo Context
            Team = new Repository<Team>(context);

            Match = new Repository<Match>(context);
            #endregion
        }

        #region Phân vùng IRepository theo Model
        public IRepository<Team> Team { get; }
        public IRepository<Match> Match { get; }
        #endregion

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
