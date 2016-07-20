using System.Collections.Generic;
using Core.Common.Contracts;
using School.Business.Entities;

namespace School.Data.Contracts.Repositories.Interfaces
{
    public interface IAlunoHistoriaRepository : IDataRepository<AlunoHistoria, string>
    {
        IEnumerable<Aluno> GetByLogin(string login, string include = "");
        IEnumerable<Aluno> GetByCodigo(string codigo, string include = "");
        IEnumerable<Aluno> GetByNomeCompleto(string nomeCompleto, string include = "");
        IEnumerable<Aluno> GetBySobrenome(string sobrenome);
    }
}