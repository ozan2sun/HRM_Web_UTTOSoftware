﻿using System.Linq.Expressions;

namespace CORE.HRM_Web_UTTOSoftware
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity Add(TEntity entity);

        TEntity Update(TEntity entity);

        void Delete(TEntity entity);

        TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes);

        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes);
    }
}
