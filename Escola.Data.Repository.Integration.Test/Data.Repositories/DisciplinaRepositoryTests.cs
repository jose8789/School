using System.Linq;
using Core.Common.Contracts;
using Core.Common.Core;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School.Business.Bootstrapper;
using School.Data.Contracts.Repositories.Interfaces;

namespace Escola.Data.Repository.Integration.Test.Data.Repositories
{
    [TestClass()]
    public class DisciplinaRepositoryTests
    {
        private IDataRepositoryFactory _factory;
        private int cursoId = 3;
        private string cursoDesig = "CFB";

        [TestInitialize()]
        public void Init()
        {
            ObjectBase.Container = UnityLoader.Init();
            _factory = ObjectBase.Container.Resolve<IDataRepositoryFactory>();
        }
        [TestMethod()]
        public void GetDisciplinasDoCursoTest()
        {
            var disciplinaRepo = _factory.GetDataRepository<IDisciplinaRepository>();
            var disciplinas = disciplinaRepo.GetDisciplinasDoCurso(cursoId, "Avaliacao");
            Assert.IsTrue(disciplinas.Any());
            Assert.IsNotNull(disciplinas.First().Avaliacao);
        }

        [TestMethod()]
        public void GetDisciplinasDoCursoTest1()
        {
            var disciplinaRepo = _factory.GetDataRepository<IDisciplinaRepository>();
            var disciplinas = disciplinaRepo.GetDisciplinasDoCurso(cursoDesig, "Avaliacao");
            Assert.IsTrue(disciplinas.Any());
            Assert.IsNotNull(disciplinas.First().Avaliacao);
        }

        [TestMethod()]
        public void GetDisciplinasDoCursoPorTipoTest()
        {
            var disciplinaRepo = _factory.GetDataRepository<IDisciplinaRepository>();
            var disciplinas = disciplinaRepo.GetDisciplinasDoCursoPorTipo(cursoDesig,"Obrigatória", "Avaliacao");
            Assert.IsTrue(disciplinas.Any());
            Assert.IsNotNull(disciplinas.First().Avaliacao);
        }

        [TestMethod()]
        public void GetDisciplinasDoCursoPorTipoTest2()
        {
            var disciplinaRepo = _factory.GetDataRepository<IDisciplinaRepository>();
            var disciplinas = disciplinaRepo.GetDisciplinasDoCursoPorTipo(cursoId, "Obrigatória", "Avaliacao");
            Assert.IsTrue(disciplinas.Any());
            Assert.IsNotNull(disciplinas.First().Avaliacao);
        }

    }
}