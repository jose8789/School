using Core.Common.Contracts;
using Core.Common.Data;

namespace School.Data
{
    public abstract class DataRepositoryBase<T,TE> : DataRepositoryBase<T,SchoolManagementContext,TE>
        where T : class, IIdentifiableEntity<TE>, new()
    {
    }
}
