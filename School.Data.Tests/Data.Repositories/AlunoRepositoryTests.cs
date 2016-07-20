using System.Collections.Generic;
using Core.Common.Contracts;
using Core.Common.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School.Business.Bootstrapper;
using School.Data.Contracts.Repositories.Interfaces;
using Moq;
using School.Business.Entities;
using School.Data.Contracts.DTOs;

namespace School.Data.Tests.Data.Repositories
{
    [TestClass()]
    public class AlunoRepositoryTests
    {
        private Mock<IDataRepositoryFactory> factory;
        private Mock<IAlunoRepository> alunoRepo;
        private Aluno aluno;
        private List<AlunoDividaInfo> _alunoDividaInfo;

        [TestInitialize]
        public void InitializeTest()
        {
            ObjectBase.Container = UnityLoader.Init();

            aluno = new Aluno() {  AlunoId = 1, Codigo = "DF4232" };
            _alunoDividaInfo = new List<AlunoDividaInfo>
            {
                new AlunoDividaInfo() {Aluno = aluno}
            };

            factory = new Mock<IDataRepositoryFactory>();

            alunoRepo = new Mock<IAlunoRepository>();
            
        }
        [TestMethod()]
        public void GetByLoginTest()
        {
            var email = "mavungo3@hotmail.com";

            factory.Setup(obj => obj.GetDataRepository<IAlunoRepository>().GetByLogin(email,"")).Returns(aluno);

            AlunoRepositoryTestClass alunoRepositoryTestClass =
                new AlunoRepositoryTestClass(factory.Object);

            var aluno1 = alunoRepositoryTestClass.GetByEmail(email);
            var aluno2 = alunoRepositoryTestClass.GetByEmail("mmm"); 

            Assert.IsNull(aluno2);
            Assert.IsNotNull(aluno1);

            Assert.IsTrue(aluno1 == aluno);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            var email = "mavungo3@hotmail.com";

            factory.Setup(obj => obj.GetDataRepository<IAlunoRepository>().GetByLogin(email,"")).Returns(aluno);

            AlunoRepositoryTestClass alunoRepositoryTestClass =
                new AlunoRepositoryTestClass(factory.Object);

            var aluno1 = alunoRepositoryTestClass.GetByEmail(email);
            var aluno2 = alunoRepositoryTestClass.GetByEmail("mmm");

            Assert.IsNull(aluno2);
            Assert.IsNotNull(aluno1);

            Assert.IsTrue(aluno1 == aluno);
        }

        [TestMethod()]
        public void GetByNomeCompletoTest()
        {
            var nome = "mavungo";

            factory.Setup(obj => obj.GetDataRepository<IAlunoRepository>().GetByNomeCompleto(nome, "")).Returns(aluno);

            AlunoRepositoryTestClass alunoRepositoryTestClass =
                new AlunoRepositoryTestClass(factory.Object);

            var aluno1 = alunoRepositoryTestClass.GetByNomeCompleto(nome);
            var aluno2 = alunoRepositoryTestClass.GetByNomeCompleto("mmm");

            Assert.IsNull(aluno2);
            Assert.IsNotNull(aluno1);

            Assert.IsTrue(aluno1 == aluno);
        }

        [TestMethod()]
        public void GetBySobrenomeTest()
        {
            var sobrenome = "mavungo3@hotmail.com";

            factory.Setup(obj => obj.GetDataRepository<IAlunoRepository>().GetBySobrenome(sobrenome)).Returns(aluno);

            AlunoRepositoryTestClass alunoRepositoryTestClass =
                new AlunoRepositoryTestClass(factory.Object);

            var aluno1 = alunoRepositoryTestClass.GetBySobrenome(sobrenome);
            var aluno2 = alunoRepositoryTestClass.GetBySobrenome("mmm");

            Assert.IsNull(aluno2);
            Assert.IsNotNull(aluno1);

            Assert.IsTrue(aluno1 == aluno);
        }
    }

    class AlunoRepositoryTestClass
    {
        private readonly IDataRepositoryFactory _factory;

        public AlunoRepositoryTestClass(IDataRepositoryFactory factory)
        {
            this._factory = factory;
        }
            
        public Aluno GetByEmail(string id)
        {
            IAlunoRepository alunoRepository = _factory.GetDataRepository<IAlunoRepository>();
            var aluno = alunoRepository.GetByLogin(id,"");
            return aluno;
        }

        public Aluno GetByIdAluno(int id)
        {
            IAlunoRepository alunoRepository = _factory.GetDataRepository<IAlunoRepository>();
            var aluno = alunoRepository.Get(id);
            return aluno;
        }

        public Aluno GetByNomeCompleto(string nomeCompleto)
        {
            IAlunoRepository alunoRepository = _factory.GetDataRepository<IAlunoRepository>();
            var aluno = alunoRepository.GetByNomeCompleto(nomeCompleto,"");
            return aluno;
        }

        public Aluno GetBySobrenome(string sobrenome)
        {
            IAlunoRepository alunoRepository = _factory.GetDataRepository<IAlunoRepository>();
            var aluno = alunoRepository.GetBySobrenome(sobrenome);
            return aluno;
        }
    }
}