﻿using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.BaseRepository
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task Add(T entity);
        Task Add(IEnumerable<T> entities);
        void Update(T entity);
        void Update(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        Task<IList<T>> All();
        Task<T> GetById(Guid? Id);

        IQueryable<T> Where(Expression<Func<T, bool>> expression);
    }
}
