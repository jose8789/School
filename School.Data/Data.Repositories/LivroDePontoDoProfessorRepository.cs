using System;
using System.Collections.Generic;
using Core.Common.Contracts;
using School.Business.Entities;
using School.Data.Contracts.DTOs;
using School.Data.Contracts.Repositories.Interfaces;

namespace School.Data.Data.Repositories
{
    public class LivroDePontoDoProfessorRepository
        : DataRepositoryBase<LivroDePontoDoProfessor, int>, ILivroDePontoDoProfessorRepository
    {
        public IEnumerable<LivroDePontoDoProfessor> GetPresencasByProfessor(int codigo, int ano, params string[] include)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LivroDePontoTurmaInfo<LivroDePontoDoProfessor, ProfessorTurma>> GetPresencaByTurma(ITurmaParameterByName turma, int ano, params string[] include)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LivroDePontoDoProfessor> GetPresencaByProfessor(int codigo, DateTime dataInicial, DateTime dataFinal, params string[] include)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LivroDePontoTurmaInfo<LivroDePontoDoProfessor, ProfessorTurma>> GetPresencaByProfessorByTurma(ITurmaParameterByName turma, DateTime dataInicial, DateTime dataFinal,
            params string[] include)
        {
            throw new NotImplementedException();
        }
    }
}