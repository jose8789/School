using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        const int SalaLength = 10;
        public void ConfigurarAlunoTurma(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlunoTurma>()
                .ToTable(nameof(AlunoTurma), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");

            modelBuilder.Entity<AlunoTurma>().Ignore(a => a.AlunoOwnerId);

            modelBuilder.Entity<AlunoTurma>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<AlunoTurma>().Property(p => p.CodigoAluno).HasMaxLength(CodigoLength);
            modelBuilder.Entity<AlunoTurma>().Property(p => p.Sala).HasMaxLength(SalaLength);
            modelBuilder.Entity<AlunoTurma>()
                .HasAlternateKey(a => new {a.TurmaId, a.CursoId, a.TurnoId, a.AnoLetivo, a.Classe, a.NumeroDoAluno});
            RelacionarAlunoTurma(modelBuilder);
        }

        public void RelacionarAlunoTurma(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlunoTurma>()
                .HasOne(a => a.Aluno)
                .WithMany(a => a.AlunoTurmas)
                .HasForeignKey(a => a.CodigoAluno)
                .HasPrincipalKey(a => a.Codigo);

            modelBuilder.Entity<AlunoTurma>()
                .HasOne(a => a.TurmaInfo)
                .WithMany(a => a.AlunoTurmas)
                .HasForeignKey(a => new { a.TurmaId, a.CursoId, a.TurnoId, a.AnoLetivo, a.Classe})
                .HasPrincipalKey(a => new { a.TurmaId, a.CursoId, a.TurnoId, a.AnoLetivo, a.Classe });
        }
    }
}