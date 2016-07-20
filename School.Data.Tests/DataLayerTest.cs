using System.Collections.Generic;
using Core.Common.Contracts;
using Core.Common.Core;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using School.Business.Bootstrapper;
using School.Business.Entities;
using School.Data.Contracts.Repositories.Interfaces;

namespace School.Data.Tests
{
    /// <summary>
    /// Summary description for DataLayerTest
    /// </summary>
    [TestClass]
    public class DataLayerTest
    {
        [TestInitialize]
        public void Initialize()
        {
            ObjectBase.Container = UnityLoader.Init();
        }

        [TestMethod]
        public void test_repository_usage()
        {
            var repository = ObjectBase.Container.Resolve<IAlunoRepository>();
            var alunos = repository.Get();

            Assert.IsTrue(alunos != null);
        }

        [TestMethod]
        public void test_repository_mocking()
        {
            List<Aluno> alunos = new List<Aluno>()
            {
                new Aluno() {AlunoId = 1, },
                new Aluno() {AlunoId = 1, }
            };
            Mock<IAlunoRepository> mockAlunoRepository = new Mock<IAlunoRepository>();
            mockAlunoRepository.Setup(obj => obj.Get()).Returns(alunos);

            RepositoryTestClass repositoryTestClass = new RepositoryTestClass(mockAlunoRepository.Object);
            var mockAlunos = repositoryTestClass.GetAlunos();
            
            Assert.IsTrue(mockAlunos == alunos);
        }

        [TestMethod]
        public void test_repository_factory_mocking()
        {
            List<Aluno> alunos = new List<Aluno>()
            {
                new Aluno() {AlunoId = 1,},
                new Aluno() {AlunoId = 1, }
            };
            Mock<IDataRepositoryFactory> mockDataRepositoryFactory =
                new Mock<IDataRepositoryFactory>();
            mockDataRepositoryFactory
                .Setup(obj => obj.GetDataRepository<IAlunoRepository>().Get())
                .Returns(alunos);

            RepositoryFactoryTestClass repositoryTestClass =
                new RepositoryFactoryTestClass(mockDataRepositoryFactory.Object);
            var mockAlunos = repositoryTestClass.GetAlunos();

            Assert.IsTrue(mockAlunos == alunos);
        }
    }

    class RepositoryTestClass
    {
        public IAlunoRepository AlunoRepository { get; set; }

        public RepositoryTestClass(IAlunoRepository alunoRepository)
        {
            this.AlunoRepository = alunoRepository;
        }

        public IEnumerable<Aluno> GetAlunos()
        {
            var alunos = AlunoRepository.Get();
            return alunos;
        }
    }
    
}
