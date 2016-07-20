using Core.Common.Contracts;
using School.Business.Entities;

namespace School.Data.Contracts.Repositories.Interfaces
{
    public interface IAlunoRepository : IDataRepository<Aluno, int>
    {
        Aluno GetByLogin(string login, params string[] includeEntities);
        Aluno GetByCodigo(string codigo, params string[] includeEntities);
        Aluno GetByNomeCompleto(string nomeCompleto, params string[] includeEntities);
        Aluno GetBySobrenome(string sobrenome, params string[] includeEntities);
        Aluno GetAlunoHistoricoDoAluno(string codigo, params string[] includeEntities);
    }
}