using School.Business.Entities;
using School.Data.Contracts.Repositories.Interfaces;

namespace School.Data.Data.Repositories
{
    public class ProfessorRepository : DataRepositoryBase<Professor, int>, IProfessorRepository
    {
    }
}
