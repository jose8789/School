using Core.Common.Contracts;
using Core.Common.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using School.Business.Bootstrapper;
using School.Business.Entities;
using School.Data.Contracts.DTOs;
using School.Data.Contracts.Repositories.Interfaces;

namespace School.Data.Tests
{
    [TestClass]
    public class DataRepositoryBaseTestClass
    {

        [TestInitialize]
        public void Initialize()
        {
            ObjectBase.Container = UnityLoader.Init();
        }

        [TestMethod]
        public void test_repository_get_by_id()
        {
            var aluno = new Aluno() {AlunoId = 1,};

            Mock<IDataRepositoryFactory> repositoryFactory = new Mock<IDataRepositoryFactory>();

            repositoryFactory.Setup(obj => obj.GetDataRepository<IAlunoRepository>().Get(1))
                .Returns(aluno);
            
            var repoTestClass = new RepositoryTestClass(repositoryFactory.Object);
            var alunoMock = repoTestClass.Get(1);

            Assert.IsTrue(aluno == alunoMock);
        }
        [TestMethod]
        public void test_repository_get_by_id2()
        {
            var alunoDef = new AlunoDeficiencia() {CodigoAluno = "DF234",DeficienciaId = 1};
            var id = new AlunoDeficienciaIdentity() {AlunoId = "DF234", DeficienciaId = 1};
            var id2 = new AlunoDeficienciaIdentity() { AlunoId = "DF235", DeficienciaId = 1 };

            Mock<IDataRepositoryFactory> repositoryFactory = new Mock<IDataRepositoryFactory>();

            repositoryFactory.Setup(obj => obj.GetDataRepository<IAlunoDeficienciaRepository>().Get(id))
                .Returns(alunoDef);

            var repoTestClass = new RepositoryTestClass(repositoryFactory.Object);
            var alunoDefMock = repoTestClass.Get(id2);

            Assert.IsFalse(alunoDef == alunoDefMock);
        }

        class RepositoryTestClass
        {
            private IDataRepositoryFactory Factory { get; set; }

            public RepositoryTestClass(IDataRepositoryFactory factory)
            {
                this.Factory = factory;
            }
                
            public Aluno Get(int id)
            {
                var alunoRepo = Factory.GetDataRepository<IAlunoRepository>();
                var alunos = alunoRepo.Get(id);
                return alunos;
            }

            public AlunoDeficiencia Get(AlunoDeficienciaIdentity id)
            {
                var alunoDeficienciaRepo = Factory.GetDataRepository<IAlunoDeficienciaRepository>();
                var alunos = alunoDeficienciaRepo.Get(id);
                return alunos;
            }

        }

    }
}
