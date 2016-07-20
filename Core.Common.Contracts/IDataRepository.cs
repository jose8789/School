using System.Collections.Generic;

namespace Core.Common.Contracts
{
    public interface IDataRepository
    {

    }

    /// <summary>
    /// This class contain the CRUD operations 
    /// that are implemented by all Repositories
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TE"></typeparam>
    public interface IDataRepository<T,TE> : IDataRepository
        where T : class, IIdentifiableEntity<TE>, new()
    {
        T Add(T entity);

        void Remove(T entity);

        void Remove(TE id);

        T Update(T entity);

        IEnumerable<T> Get();

        T Get(TE id);
    }
}
