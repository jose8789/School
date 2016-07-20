using System;
using System.Collections.Generic;
using Core.Common.Contracts;
using School.Business.Entities;
using School.Data.Contracts.DTOs;

namespace School.Data.Contracts.Repositories.Interfaces
{
    public interface ILivroDePontoDoAlunoRepository : IDataRepository<LivroDePontoDoAluno, int>
    {
        IEnumerable<LivroDePontoDoAluno> GetPresencasByAluno(string codigo,int ano, params string[] include);        
        IEnumerable<LivroDePontoTurmaInfo<LivroDePontoDoAluno,AlunoTurma>> GetPresencaByTurma(ITurmaParameterByName turma, int ano, params string[] include);
        IEnumerable<LivroDePontoDoAluno> GetPresencaByAluno(string codigo, DateTime dataInicial, DateTime dataFinal, params string[] include);
        IEnumerable<LivroDePontoTurmaInfo<LivroDePontoDoAluno,AlunoTurma>> GetPresencaByTurma(ITurmaParameterByName turma, DateTime dataInicial, DateTime dataFinal, params string[] include);
    }
}