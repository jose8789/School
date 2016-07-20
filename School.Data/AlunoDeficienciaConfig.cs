using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarAlunoDeficiencia(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlunoDeficiencia>()
                .ToTable(nameof(AlunoDeficiencia), Schema.Giva)
                .Ignore(a => a.ExtensionData)
                .Ignore(a => a.EntityId)
                .Ignore(a=>a.AlunoOwnerId)
                .Ignore(a=>a.AlunoDeficienciaIdentity)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<AlunoDeficiencia>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            modelBuilder.Entity<AlunoDeficiencia>()
                .HasKey(a => new {a.CodigoAluno, a.DeficienciaId});

            ConfigurarAlunoDeficienciaProp(modelBuilder);
            RelacionarAlunoDeficiencia(modelBuilder);
        }

        public void ConfigurarAlunoDeficienciaProp(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlunoDeficiencia>().Property(p => p.CodigoAluno).HasMaxLength(CodigoLength);
        }
        public void RelacionarAlunoDeficiencia(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Deficiencia>()
                .HasMany(a => a.AlunoDeficiencias)
                .WithOne(a => a.Deficiencia)
                .HasForeignKey(a => a.DeficienciaId);

            modelBuilder.Entity<AlunoDeficiencia>()
                .HasOne(a => a.Aluno)
                .WithMany(a => a.AlunoDeficiencia)
                .HasForeignKey(a => a.CodigoAluno)
                .HasPrincipalKey(a => a.Codigo);
        }
    }
}