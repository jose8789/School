using System;
using System.Collections.Generic;
using Core.Common.Contracts;
using School.Business.Entities;
using School.Data.Contracts.DTOs;

namespace School.Data.Contracts.Repositories.Interfaces
{
    public interface ILivroDePontoDoProfessorRepository : IDataRepository<LivroDePontoDoProfessor, int>
    {
        IEnumerable<LivroDePontoDoProfessor> GetPresencasByProfessor(int codigo, int ano, params string[] include );
        IEnumerable<LivroDePontoTurmaInfo<LivroDePontoDoProfessor,ProfessorTurma>> GetPresencaByTurma(ITurmaParameterByName turma, int ano, params string[] include );
        IEnumerable<LivroDePontoDoProfessor> GetPresencaByProfessor(int codigo, DateTime dataInicial, DateTime dataFinal, params string[] include);
        IEnumerable<LivroDePontoTurmaInfo<LivroDePontoDoProfessor,ProfessorTurma>> GetPresencaByProfessorByTurma(ITurmaParameterByName turma, DateTime dataInicial, DateTime dataFinal, params string[] include);
    }
}