using Core.Common.Contracts;
using Core.Common.Core;
using Microsoft.Practices.Unity;

namespace School.Data
{
    public class DataRepositoryFactory : IDataRepositoryFactory
    {
        public T GetDataRepository<T>() where T : IDataRepository
        {
            return ObjectBase.Container.Resolve<T>();
        }
    }
}
