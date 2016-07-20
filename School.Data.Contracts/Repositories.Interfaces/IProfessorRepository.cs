using Core.Common.Contracts;
using School.Business.Entities;

namespace School.Data.Contracts.Repositories.Interfaces
{
    public interface IProfessorRepository : IDataRepository<Professor, int>
    {
    }
}