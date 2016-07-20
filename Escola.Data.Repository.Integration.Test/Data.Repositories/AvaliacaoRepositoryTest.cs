using System;
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
    public class AvaliacaoRepositoryTest
    {
        private IDataRepositoryFactory _factory;
        private DateTime _date1;
        private DateTime _date2;
        private ITurmaParameterByName _turma;
        private string _disciplina;

        [TestInitialize]
        public void Init()
        {
            ObjectBase.Container = UnityLoader.Init();
            _factory = ObjectBase.Container.Resolve<IDataRepositoryFactory>();
            _date1 = new DateTime(2016, 1, 1);
            _date2 = _date1.AddMonths(7);
            _turma = ObjectBase.Container.Resolve<ITurmaParameterByName>();
            _turma.Sala = 4;
            _turma.AnoLetivo = 2016;
            _turma.Classe = 10;
            _turma.TurnoDesignacao = "Matinal";
            _turma.CursoAbreviacao = "TI";
            _turma.TurmaDesignacao = "C";
            _disciplina = "QCA";
        }
        [TestMethod]
        public void GetAvaliacoesPorAlunoTest()
        {
            var avaliacaoRepo = _factory.GetDataRepository<IAvaliacaoRepository>();
            var alunos = avaliacaoRepo.GetAvaliacoesPorAluno("DF1",_date1,_date2,"Aluno");
            Assert.IsTrue(alunos.Any(a=>a.CodigoAluno == "DF1"));
            Assert.IsNotNull(alunos.First().Aluno);
        }

        [TestMethod]
        public void GetAvaliacoesByAlunoAndDisciplinaTest()
        {
            
            var avaliacaoRepo = _factory.GetDataRepository<IAvaliacaoRepository>();
            var alunos = avaliacaoRepo.GetAvaliacoesPorAlunoEDisciplina("DF11",_date1,_date2, _disciplina,"Aluno");
            Assert.IsTrue(alunos.Any(a=>a.CodigoAluno == "DF11"));
            Assert.IsNotNull(alunos.First().Aluno);
        }
        [TestMethod]
        public void GetAvaliacoesByTurmaEdisciplinaTest()
        {
            var avaliacaoRepo = _factory.GetDataRepository<IAvaliacaoRepository>();
            var alunos = avaliacaoRepo.GetAvaliacoesPorTurmaEDisciplina(_turma,_date1,_date2,_disciplina,"Aluno");
            Assert.IsNotNull(alunos.FirstOrDefault()?.Aluno);
            Assert.IsNotNull(alunos.First().Aluno);
        }
    }
}
