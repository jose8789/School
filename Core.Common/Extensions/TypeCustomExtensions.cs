using System.Reflection;

namespace Core.Common.Extensions
{
    public static class TypeCustomExtensions
    {
        public static PropertyInfo GetProperty<T>(this T entity,string property) where T : class
        {
            return entity.GetType().GetProperty(property);
        } 
    }
}
