using System;
using System.Collections.Generic;
using Core.Common.Contracts;
using School.Business.Entities;

namespace School.Data.Contracts.Repositories.Interfaces
{
    public interface IAvaliacaoRepository : IDataRepository<Avaliacao, int>
    {
        IEnumerable<Avaliacao> GetAvaliacoesPorAluno(string codigo, DateTime date1, DateTime date2, params string[] includeEntities);
        IEnumerable<Avaliacao> GetAvaliacoesPorTurma(ITurmaParameterByName turma, DateTime date1, DateTime date2, params string[] includeEntities);
        IEnumerable<Avaliacao> GetAvaliacoesPorAlunoEDisciplina(string codigo, DateTime date1, DateTime date2, string disciplinaCode, params string[] includeEntities);
        IEnumerable<Avaliacao> GetAvaliacoesPorTurmaEDisciplina(ITurmaParameterByName turma, DateTime date1, DateTime date2,string disciplinaCode, params string[] includeEntities);
    }
}