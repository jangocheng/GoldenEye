﻿using System.Linq;
using Shared.Core;

namespace Backend.Core.Repository
{
    public interface IRepository<TEntity> : IReadonlyRepository<TEntity> where TEntity : class, IHasId
    {
        TEntity Add(TEntity entity);
        IQueryable<TEntity> AddAll(IQueryable<TEntity> entities);
        TEntity Update(TEntity entity);
        int SaveChanges();
        TEntity Delete(TEntity entity);
        bool Delete(int id);
    }
}