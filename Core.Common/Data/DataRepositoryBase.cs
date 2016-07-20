using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.Common.Contracts;
using Core.Common.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Core.Common.Data
{
    public abstract class DataRepositoryBase<T, U, TE> : IDataRepository<T, TE>
        where T : class, IIdentifiableEntity<TE>, new()
        where U : DbContext, new()
    {
        public T Add(T entity)
        {
            using (var context = new U())
            {
                var addedEntity = context.Set<T>().Add(entity).Entity;
                context.SaveChanges();
                return addedEntity;
            }
        }

        public void Remove(T entity)
        {
            using (var context = new U())
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }

        public void Remove(TE id)
        {
            using (var context = new U())
            {
                var entity = context.Set<T>().FirstOrDefault(a => a.EntityId.Equals(id));
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public T Update(T entity)
        {
            using (var context = new U())
            {
                return context.Set<T>().Update(entity).Entity;
            }
        }

        public IEnumerable<T> Get()
        {
            using (var context = new U())
            {
                return context.Set<T>().Select(a => a);
            }
        }

        public T Get(TE id)
        {
            using (var context = new U())
            {
                return context.Set<T>().FirstOrDefault(a => a.EntityId.Equals(id));
            }
        }

        protected IEnumerable<T> ExecutarCodigo(Expression<Func<T, bool>> filter, params string[] includeEntities)
        {
            using (var contexto = new U())
            {
                var dbset = contexto.Set<T>();

                var flag = includeEntities != null &&
                           includeEntities.All(a => !a.IsNullOrEmptyOrWhiteSpace());

                var query = flag ? dbset.Include(includeEntities) : dbset;

                query = filter != null ? query.Where(filter) : query;

                return query.ToFullyLoaded();
            }
        }

        protected IEnumerable<E> ExecutarCodigo<E>(IQueryable<E> query, Expression<Func<E, bool>> filter, params string[] includeEntities) where E : class
        {
            var flag = includeEntities != null &&
                       includeEntities.All(a => !a.IsNullOrEmptyOrWhiteSpace());

            query = flag ? query.Include(includeEntities) : query;

            query = filter != null ? query.Where(filter) : query;

            return query.ToFullyLoaded();
        }

        
    }
}