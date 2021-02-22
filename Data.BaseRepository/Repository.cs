﻿using Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.BaseRepository
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private DbContext context;
        private readonly IUnitOfWork IUnitOfWork;
        DbSet<T> Table { get; set; }
        public Repository(GvResourceContext context)
        {
            Table = context.Set<T>();
        }

        public Repository(DbContext context)
        {
            this.context = context;
        }

        public async Task Add(T entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task Add(IEnumerable<T> entities)
        {
            await Table.AddRangeAsync(entities);
        }

        public async Task<IList<T>> All()
        {
            return await Table.AsNoTracking().ToListAsync();
        }

        public void Delete(T entity)
        {
            Table.Remove(entity);
        }

        public void Delete(IEnumerable<T> entities)
        {
            Table.RemoveRange(entities);
        }

        public async Task<T> GetById(Guid? ID)
        {
            return await Table.SingleAsync(x => x.ID == ID);
        }

        public void Update(T entity)
        {
            Table.Update(entity);
        }

        public async void Update(IEnumerable<T> entities)
        {
            Table.UpdateRange();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return Table.Where<T>(expression);
        }
    }
}
