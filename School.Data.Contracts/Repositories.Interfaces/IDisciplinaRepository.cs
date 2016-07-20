using System.Collections.Generic;
using Core.Common.Contracts;
using School.Business.Entities;

namespace School.Data.Contracts.Repositories.Interfaces
{
    public interface IDisciplinaRepository : IDataRepository<Disciplina, int>
    {
        IEnumerable<Disciplina> GetDisciplinasDoCurso(int cursoId, params string[] includeEntities);
        IEnumerable<Disciplina> GetDisciplinasDoCurso(string cursoAbr, params string[] includeEntities);

        IEnumerable<Disciplina> GetDisciplinasDoCursoPorTipo(int cursoId,string tipoDeFormacao, params string[] includeEntities);
        IEnumerable<Disciplina> GetDisciplinasDoCursoPorTipo(string cursoAbrev, string tipoDeFormacao, params string[] includeEntities);
    }
}   