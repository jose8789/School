using System.Collections.Generic;
using Core.Common.Contracts;
using School.Business.Entities;
using School.Data.Contracts.DTOs;
using School.Data.Contracts.Repositories.Interfaces;

namespace School.Data.Data.Repositories
{
    public class PropinaRepository : DataRepositoryBase<Propina, int>, IPropinaRepository
    {
        public IEnumerable<Propina> GetPropinasDosAlunos(int ano, params string[] include)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<AlunoDividaInfo> GetAlunosDevedores(int ano, params string[] include)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Propina> GetPropinasDoAluno(string codigo, int ano, params string[] include)
        {
            throw new System.NotImplementedException();
        }

        public AlunoDividaInfo GetAlunoDevedor(string codigo, int ano, params string[] include)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<PropinaTurmaInfo> GetPropinasDaTurma(ITurmaParameterByName turma, int ano, params string[] include)
        {
            throw new System.NotImplementedException();
        }
    }
}