using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.Practices.ObjectBuilder2;
using School.Business.Entities;
using School.Data.Contracts.Repositories.Interfaces;

namespace School.Data.Data.Repositories
{
    public class AlunoRepository : DataRepositoryBase<Aluno, int>, IAlunoRepository
    {
        public Aluno GetByLogin(string login, params string[] includeEntities)
        {
            Expression<Func<Aluno, bool>> filter = a => a.Pessoa.LoginName == login;
            return ExecutarCodigo(filter, includeEntities).SingleOrDefault();
        }

        public Aluno GetByCodigo(string codigo, params string[] includeEntities)
        {
            return ExecutarCodigo(a => a.Codigo == codigo, includeEntities).SingleOrDefault();
        }

        public Aluno GetByNomeCompleto(string nomeCompleto, params string[] includeEntities)
        {
            Expression<Func<Aluno, bool>> filter 
                = a => $"{a.Pessoa.PrimeiroNome} {a.Pessoa.NomeMedio} {a.Pessoa.UltimoNome}" == nomeCompleto;
            return ExecutarCodigo(filter, includeEntities).SingleOrDefault();
        }

        public Aluno GetBySobrenome(string sobrenome, params string[] includeEntities)
        {
            return ExecutarCodigo(a => a.Pessoa.UltimoNome == sobrenome, includeEntities)
                .SingleOrDefault();
        }

        public Aluno GetAlunoHistoricoDoAluno(string codigo, params string[] includeEntities)
        {
            return ExecutarCodigo(a => a.Codigo == codigo,includeEntities).SingleOrDefault();
        }
    }
}