using System.Linq;
using Core.Common.Contracts;
using Core.Common.Core;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School.Business.Bootstrapper;
using School.Data.Contracts.Repositories.Interfaces;

namespace Escola.Data.Repository.Integration.Test.Data.Repositories
{
    [TestClass]
    public class AlunoDeficienciaRepositoryTest
    {
        private IDataRepositoryFactory _factory;

        [TestInitialize]
        public void Init()
        {
            ObjectBase.Container = UnityLoader.Init();
            _factory = ObjectBase.Container.Resolve<IDataRepositoryFactory>();
        }
        [TestMethod]
        public void GetAlunoDeficienciasTest()
        {
            var alunoDificienciaRepo = _factory.GetDataRepository<IAlunoDeficienciaRepository>();
            var aluno = alunoDificienciaRepo.GetDeficienciasDosAlunos("DF10", "Aluno");
            Assert.IsNotNull(aluno);
            Assert.IsNotNull(aluno.First().Aluno);
        }

        [TestMethod]
        public void GetAlunosDeficienciasTest()
        {
            var alunoDificienciaRepo = _factory.GetDataRepository<IAlunoDeficienciaRepository>();
            var aluno = alunoDificienciaRepo.GetAllDeficienciasDosAlunos("Aluno");
            Assert.IsNotNull(aluno);
            Assert.IsNotNull(aluno.First().Aluno);
        }
        [TestMethod]
        public void GetAlunosDeficienciasPorAnoTest()
        {
            var alunoDificienciaRepo = _factory.GetDataRepository<IAlunoDeficienciaRepository>();
            var aluno = alunoDificienciaRepo.GetAlunosDeficienciasPorAno(2016,"Aluno");
            Assert.IsNotNull(aluno);
            Assert.IsNotNull(aluno.First().Aluno);
        }
        [TestMethod]
        public void GetAlunosDeficienciasPorClasseTest()
        {
            var alunoDificienciaRepo = _factory.GetDataRepository<IAlunoDeficienciaRepository>();
            var alunos = alunoDificienciaRepo.GetDeficienciasDosAlunosPorClasse(10,"Aluno");
            Assert.IsNotNull(alunos);
            Assert.IsNotNull(alunos.First().Aluno);
        }
        [TestMethod]
        public void GetAlunosDeficienciasPorTurmaTest()
        {
            var alunoDificienciaRepo = _factory.GetDataRepository<IAlunoDeficienciaRepository>();
            ITurmaParameterByName p = ObjectBase.Container.Resolve<ITurmaParameterByName>();
            p.Classe = 10;
            p.TurnoDesignacao = "Matinal";
            p.TurmaDesignacao = "A";
            p.CursoAbreviacao = "TI";
            p.Sala = 3;
            p.AnoLetivo = 2016;
            //var alunos = alunoDificienciaRepo.GetDeficienciasDosAlunosPorTurma(p,"Aluno");
            //Assert.IsNotNull(alunos);
            //Assert.IsNotNull(alunos.First().Aluno);
        }
    }
}
