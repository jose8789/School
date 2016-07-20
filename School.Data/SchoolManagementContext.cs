using System.Linq;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Practices.ObjectBuilder2;
using School.Business.Entities;

namespace School.Data
{
    public sealed partial class SchoolManagementContext : DbContext
    {
        public SchoolManagementContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }


        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<AlunoDeficiencia> AlunoDeficiencias { get; set; }
        public DbSet<AlunoDisciplinaEmAtraso> AlunoDisciplinasEmAtraso { get; set; }
        public DbSet<AlunoProfissao> AlunoProfissoes { get; set; }
        public DbSet<AlunoTurma> AlunoTurmas { get; set; }
        public DbSet<AreaDeFormacao> AreasDeFormacao { get; set; }
        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Bilhete> Bilhetes { get; set; }
        public DbSet<BusinessEntity> BusinessEntities { get; set; }
        public DbSet<BusinessEntityMorada> BusinessEntityMoradas { get; set; }
        public DbSet<Comuna> Comunas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<CursoDisciplina> CursoDisciplina { get; set; }
        public DbSet<CursoDisciplinaOpcional> CursoDisciplinaOpcionais { get; set; }

        public DbSet<CursoInfo> CursoInfo { get; set; }
        public DbSet<Deficiencia> Deficiencias { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<DisciplinaInfo> DisciplinaInfo { get; set; }
        public DbSet<EncarregadoDeEducacao> EncarregadosDeEducacao { get; set; }
        public DbSet<Escola> Escolas { get; set; }
        public DbSet<LivroDePonto> LivroDePontos { get; set; }
        public DbSet<LivroDePontoDoAluno> LivroDePontoDosAlunos { get; set; }
        public DbSet<LivroDePontoDoProfessor> LivroDePontoDosProfessores { get; set; }
        public DbSet<Localizacao> Localizacoes { get; set; }
        public DbSet<Morada> Moradas { get; set; }
        public DbSet<NivelAcademico> NiveisAcademico { get; set; }
        public DbSet<Observacao> Observacoes { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Password> Password { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<ProfessorAreaDeFormacao> ProfessorAreasDeFormacao { get; set; }
        public DbSet<ProfessorTurma> ProfessorTurma { get; set; }
        public DbSet<Profissao> Profissoes { get; set; }
        public DbSet<Propina> Propinas { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<TipoDeAvaliacao> TiposDeAvaliacao { get; set; }
        public DbSet<TipoDeMorada> TiposDeMorada { get; set; }
        public DbSet<TipoDeFormacao> TiposDeFormacoes { get; set; }
        public DbSet<TipoDeNumeroDeTelefone> TiposDeNumeroDeTelefone { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<TurmaInfo> TurmaInfo { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<TurnoInfo> TurnoInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"data source=.;initial catalog=EscolaDb;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        }

        private void EliminarTipos(ModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Ignore<IExtensibleDataObject>();
            modelBuilder.Ignore<IIdentifiableEntity>();
            modelBuilder.Ignore<IAccountOwnedEntity>();
            modelBuilder.Ignore<IAlunoOwnedEntity>();
            modelBuilder.Ignore<IDiretorOwnedEntity>();
            modelBuilder.Ignore<ICoordenadorOwnedEntity>();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            EliminarTipos(modelBuilder);
            typeof(SchoolManagementContext).GetMethods()
                .Where(m => m.Name.StartsWith("Config"))
                .ForEach(a=>a.Invoke(this, new object[] { modelBuilder }));
         
        }
    }
}