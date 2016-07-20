using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarProfessorAreaDeFormacao(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProfessorAreaDeFormacao>()
                .ToTable(nameof(ProfessorAreaDeFormacao), Schema.Giva)
                .Ignore(a => a.ExtensionData)
                .Ignore(a=>a.FuncionarioOwnerId)
                .Ignore(a=>a.ProfessorAreaDeFormacaoIdentity)
                .Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<ProfessorAreaDeFormacao>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            modelBuilder.Entity<ProfessorAreaDeFormacao>()
                .HasKey(a => new {a.ProfessorId, a.AreaDeFormacaoId});

            modelBuilder.Entity<Professor>()
                .HasMany(a => a.ProfessorAreasDeFormacao)
                .WithOne(a => a.Professor)
                .HasForeignKey(a => a.ProfessorId);

            modelBuilder.Entity<AreaDeFormacao>()
                .HasMany(a => a.ProfessorAreasDeFormacao)
                .WithOne(a => a.AreaDeFormacao)
                .HasForeignKey(a => a.AreaDeFormacaoId);
        }

        public void RelacionarProfessorAreaDeFormacao(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Deficiencia>()
            //    .HasMany(a => a.AlunoDeficiencias)
            //    .WithOne(a => a.Deficiencia)
            //    .HasForeignKey(a => a.DeficienciaId);

            //modelBuilder.Entity<Aluno>()
            //   .HasMany(a => a.AlunoDeficiencia)
            //   .WithOne(a => a.Aluno)
            //   .HasForeignKey(a => a.AlunoId);
        }
    }
}