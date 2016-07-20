using System.Collections.Generic;
using Core.Common.Contracts;
using School.Business.Entities;
using School.Data.Contracts.DTOs;

namespace School.Data.Contracts.Repositories.Interfaces
{
    public interface IPropinaRepository : IDataRepository<Propina, int>
    {
        IEnumerable<Propina> GetPropinasDosAlunos(int ano, params string[] include );
        IEnumerable<AlunoDividaInfo> GetAlunosDevedores(int ano, params string[] include);
        IEnumerable<Propina> GetPropinasDoAluno(string codigo, int ano, params string[] include);
        AlunoDividaInfo GetAlunoDevedor(string codigo, int ano, params string[] include );
        IEnumerable<PropinaTurmaInfo> GetPropinasDaTurma(ITurmaParameterByName turma, int ano, params string[] include);
    }
}