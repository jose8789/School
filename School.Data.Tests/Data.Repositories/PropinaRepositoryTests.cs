using System.Collections.Generic;
using System.Linq;
using Core.Common.Contracts;
using Core.Common.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using School.Business.Bootstrapper;
using School.Business.Entities;
using School.Data.Contracts.DTOs;
using School.Data.Contracts.Repositories.Interfaces;

namespace School.Data.Tests.Data.Repositories
{
    [TestClass()]
    public class PropinaRepositoryTests
    {
        private Mock<IDataRepositoryFactory> _factory;
        private Aluno _aluno;
        private List<AlunoDividaInfo> _alunoDividaInfo;
        private Mock<IAlunoRepository> _propinaRepo;

        [TestInitialize]
        public void InitializeTest()
        {
            ObjectBase.Container = UnityLoader.Init();

            _aluno = new Aluno() {  AlunoId = 1, Codigo = "DF4232" };
            _alunoDividaInfo = new List<AlunoDividaInfo>
            {
                new AlunoDividaInfo() {Aluno = _aluno}
            };

            _factory = new Mock<IDataRepositoryFactory>();

            _propinaRepo = new Mock<IAlunoRepository>();

        }

        [TestMethod()]
        public void GetAlunoDevedorTest()
        {
            var ano = 2014;
            var codigo = "DF4504";
            var prop = new AlunoDividaInfo() {Aluno = _aluno};

            _factory.Setup(obj => obj.GetDataRepository<IPropinaRepository>().GetAlunoDevedor(codigo,ano, "")).Returns(prop);

            var propinaRepositoryTestClass =
                new PropinaRepositoryTestClass(_factory.Object);

            var aluno1 = propinaRepositoryTestClass.GetAlunoDevedor(codigo,ano);

            Assert.IsNotNull(aluno1);

            Assert.IsTrue(aluno1.Aluno == _aluno);
        }
        
        [TestMethod]
        public void GetPropinasDosAlunosTest()
        {
            var ano = 2014;
            var prop = new List<Propina>()
            {
                new Propina() { Aluno = _aluno }
            };

            _factory.Setup(obj => obj.GetDataRepository<IPropinaRepository>().GetPropinasDosAlunos(ano, "")).Returns(prop);

            var propinaRepositoryTestClass =
                new PropinaRepositoryTestClass(_factory.Object);

            var aluno1 = propinaRepositoryTestClass.GetPropinasDosAlunos(ano);

            Assert.IsNotNull(aluno1);

            Assert.IsTrue(aluno1.FirstOrDefault()?.Aluno == _aluno);
        }

        [TestMethod]
        public void GetAlunosDevedoresTest()
        {
            var ano = 2014;
            var codigo = "DF2340";

            _factory.Setup(obj => obj.GetDataRepository<IPropinaRepository>().GetAlunoDevedor(codigo, ano, "")).Returns(_alunoDividaInfo?.FirstOrDefault());

            var propinaRepositoryTestClass =
                new PropinaRepositoryTestClass(_factory.Object);

            var aluno1 = propinaRepositoryTestClass.GetAlunoDevedor(codigo, ano);

            Assert.IsNotNull(aluno1);

            Assert.IsTrue(aluno1.Aluno == _aluno);
        }

        [TestMethod]
        public void GetPropinasDoAlunoTest()
        {
            var ano = 2014;
            var codigo = "DF2340";
            var prop = new List<Propina>() { new Propina() { Aluno = _aluno }};

            _factory.Setup(obj => obj.GetDataRepository<IPropinaRepository>().GetPropinasDoAluno(codigo, ano, "")).Returns(prop);

            var propinaRepositoryTestClass =
                new PropinaRepositoryTestClass(_factory.Object);

            var aluno1 = propinaRepositoryTestClass.GetPropinasDoAluno(codigo, ano);

            Assert.IsNotNull(aluno1);

            Assert.IsTrue(aluno1.FirstOrDefault()?.Aluno == _aluno);
        }
    }

    class PropinaRepositoryTestClass
    {
        private readonly IDataRepositoryFactory _factory;

        public PropinaRepositoryTestClass(IDataRepositoryFactory factory)
        {
            this._factory = factory;
        }
        
        public IEnumerable<Propina> GetPropinasDosAlunos(int ano, string include = "")
        {
            var propinaRepository = _factory.GetDataRepository<IPropinaRepository>();
            var alunos = propinaRepository.GetPropinasDosAlunos(ano, include);
            return alunos;
        }

        public IEnumerable<AlunoDividaInfo> GetAlunosDevedores(int ano, string include = "")
        {
            var propinaRepository = _factory.GetDataRepository<IPropinaRepository>();
            var alunos = propinaRepository.GetAlunosDevedores(ano, include);
            return alunos;
        }

        public IEnumerable<Propina> GetPropinasDoAluno(string codigo, int ano, string include = "")
        {
            var propinaRepository = _factory.GetDataRepository<IPropinaRepository>();
            var aluno = propinaRepository.GetPropinasDoAluno(codigo, ano, include);
            return aluno;
        }

        public AlunoDividaInfo GetAlunoDevedor(string codigo, int ano, string include = "")
        {
            var propinaRepository = _factory.GetDataRepository<IPropinaRepository>();
            var aluno = propinaRepository.GetAlunoDevedor(codigo, ano, include);
            return aluno;
        }
    }
}