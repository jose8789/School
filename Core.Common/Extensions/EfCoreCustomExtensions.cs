using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Core.Common.Extensions
{
    public static class EfCoreCustomExtensions
    {
        public static IIncludableQueryable<TEntity, TProperty> Include<TEntity, TProperty>(this IQueryable<TEntity> query, string property) where TEntity : class where TProperty : PropertyInfo
        {
            IEnumerable<PropertyInfo> properties = 
                typeof(TEntity).GetTypeInfo().DeclaredProperties;

            DbSet<TEntity> set = query.GetType()
                .GetTypeInfo()
                .DeclaredProperties
                .FirstOrDefault(a => a == typeof(DbSet<TEntity>).GetTypeInfo()) as DbSet<TEntity>;


            dynamic result = null;

            foreach (var propertyInfo in properties)
            {
                if (propertyInfo.Name == property)
                {
                    result = set?.Include(a => a.GetType().GetProperty(property).GetType());
                }
            }
            return result;
        }
    }
}
