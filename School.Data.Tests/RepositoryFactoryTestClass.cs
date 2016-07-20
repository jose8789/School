using System.Collections.Generic;
using Core.Common.Contracts;
using School.Business.Entities;
using School.Data.Contracts.Repositories.Interfaces;

namespace School.Data.Tests
{
    class RepositoryFactoryTestClass    
    {
        public IDataRepositoryFactory DataRepositoryFactory { get; set; }

        public RepositoryFactoryTestClass(IDataRepositoryFactory factory)
        {
            this.DataRepositoryFactory = factory;
        }

        public IEnumerable<Aluno> GetAlunos()
        {
            var alunoRepository = DataRepositoryFactory.GetDataRepository<IAlunoRepository>();
            var alunos = alunoRepository.Get();
            return alunos;
        }
    }
    
}
