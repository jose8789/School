using Core.Common.Contracts;
using Core.Common.Core;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School.Business.Bootstrapper;
using School.Data.Contracts.Repositories.Interfaces;

namespace Escola.Data.Repository.Integration.Test.Data.Repositories
{
    [TestClass]
    public class AlunoRepositoryTest
    {
        private IDataRepositoryFactory _factory;

        [TestInitialize]
        public void Init()
        {
            ObjectBase.Container = UnityLoader.Init();
            _factory = ObjectBase.Container.Resolve<IDataRepositoryFactory>();
        }
        [TestMethod]
        public void GetAlunoGetByLoginTest()
        {
            var alunoRepo = _factory.GetDataRepository<IAlunoRepository>();
            var aluno = alunoRepo.GetByLogin("Mingas87","Pessoa.Pais", "Curso");
            Assert.IsNotNull(aluno);
            Assert.IsNotNull(aluno.Pessoa);
            Assert.IsNotNull(aluno.Pessoa.Pais);
            Assert.IsNotNull(aluno.Curso);
        }

        [TestMethod]
        public void GetByCodigoTest()
        {
            var alunoRepo = _factory.GetDataRepository<IAlunoRepository>();
            var aluno = alunoRepo.GetByCodigo("DF1", "Pessoa.Pais", "Curso");
            Assert.IsNotNull(aluno);
            Assert.IsNotNull(aluno.Pessoa);
            Assert.IsNotNull(aluno.Pessoa.Pais);
            Assert.IsNotNull(aluno.Curso);
        }
        [TestMethod]
        public void GetByNomeCompletoTest()
        {
            var alunoRepo = _factory.GetDataRepository<IAlunoRepository>();
            var aluno = alunoRepo.GetByNomeCompleto("Antonio Rodrigues Mingas", "Pessoa.Pais", "Curso");
            Assert.IsNotNull(aluno);
            Assert.IsNotNull(aluno.Pessoa);
            Assert.IsNotNull(aluno.Pessoa.Pais);
            Assert.IsNotNull(aluno.Curso);
        }
        [TestMethod]
        public void GetBySobrenomeTest()
        {
            var alunoRepo = _factory.GetDataRepository<IAlunoRepository>();
            var aluno = alunoRepo.GetBySobrenome("Biala","Pessoa.Pais", "Curso");
            Assert.IsNotNull(aluno);
            Assert.IsNotNull(aluno.Pessoa);
            Assert.IsNotNull(aluno.Pessoa.Pais);
            Assert.IsNotNull(aluno.Curso);
        }
        [TestMethod]
        public void GetAlunoHistoricoDoAlunoTest()
        {
            var alunoRepo = _factory.GetDataRepository<IAlunoRepository>();
            var aluno = alunoRepo.GetAlunoHistoricoDoAluno("DF5", "Pessoa.Pais", "Curso", "Avaliacoes");
            Assert.IsNotNull(aluno);
            Assert.IsNotNull(aluno.Pessoa);
            Assert.IsNotNull(aluno.Pessoa.Pais);
            Assert.IsNotNull(aluno.Curso);
            Assert.IsNotNull(aluno.Avaliacoes);
            Assert.IsNotNull(aluno.LivroDePontoDosAlunos);
        }
    }
}
