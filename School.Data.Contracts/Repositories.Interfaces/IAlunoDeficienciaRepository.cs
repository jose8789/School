using System.Collections.Generic;
using Core.Common.Contracts;
using School.Business.Entities;
using School.Data.Contracts.DTOs;

namespace School.Data.Contracts.Repositories.Interfaces
{
    public interface IAlunoDeficienciaRepository : IDataRepository<AlunoDeficiencia, AlunoDeficienciaIdentity>
    {
        IEnumerable<AlunoDeficiencia> GetDeficienciasDosAlunos(string codigo,params string[] includeEntities);
        IEnumerable<AlunoDeficiencia> GetAllDeficienciasDosAlunos(params string[] includeEntities);
        IEnumerable<AlunoDeficiencia> GetAlunosDeficienciasPorAno(int ano, params string[] includeEntities);
        IEnumerable<AlunoDeficiencia> GetDeficienciasDosAlunosPorClasse(int classe,params string[] includeEntities);
        IEnumerable<AlunoDeficiencia> GetDeficienciasDosAlunosPorTurma(ITurmaParameterByName turma,params string[] includeEntities);
    }
}