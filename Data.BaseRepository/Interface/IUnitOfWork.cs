﻿using Data.Entity;
using Data.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Data.BaseRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Match> Match { get; }
        IRepository<Team> Team { get; }
        IQueryable<TEntity> Queryable<TEntity>() where TEntity : class;
    }
}
