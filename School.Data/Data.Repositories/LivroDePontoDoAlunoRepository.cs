using System;
using System.Collections.Generic;
using Core.Common.Contracts;
using School.Business.Entities;
using School.Data.Contracts.DTOs;
using School.Data.Contracts.Repositories.Interfaces;

namespace School.Data.Data.Repositories
{
    public class LivroDePontoDoAlunoRepository : DataRepositoryBase<LivroDePontoDoAluno, int>,
        ILivroDePontoDoAlunoRepository
    {
        public IEnumerable<LivroDePontoDoAluno> GetPresencasByAluno(string codigo, int ano, params string[] include)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LivroDePontoTurmaInfo<LivroDePontoDoAluno, AlunoTurma>> GetPresencaByTurma(ITurmaParameterByName turma, int ano, params string[] include)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LivroDePontoDoAluno> GetPresencaByAluno(string codigo, DateTime dataInicial, DateTime dataFinal, params string[] include)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LivroDePontoTurmaInfo<LivroDePontoDoAluno, AlunoTurma>> GetPresencaByTurma(ITurmaParameterByName turma, DateTime dataInicial, DateTime dataFinal, params string[] include)
        {
            throw new NotImplementedException();
        }
    }
}