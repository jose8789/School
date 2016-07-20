using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        private const int CodigoLength = 25;
        public void ConfigurarAlunoDisciplinaEmAtraso(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlunoDisciplinaEmAtraso>()
                .ToTable(nameof(AlunoDisciplinaEmAtraso), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData)
                .Ignore(a => a.EntityId)
                .Ignore(a=>a.AlunoDeficienciaIdentity)
                .Ignore(a=>a.AlunoOwnerId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<AlunoDisciplinaEmAtraso>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            modelBuilder.Entity<AlunoDisciplinaEmAtraso>().Property(p => p.CodigoAluno).HasMaxLength(CodigoLength);

            modelBuilder.Entity<AlunoDisciplinaEmAtraso>()
                .HasKey(a => new {a.CodigoAluno, a.DisciplinaId, a.AnoLetivo, a.Classe});
            RelacionarAlunoDisciplinaEmAtraso(modelBuilder);
        }

        public void RelacionarAlunoDisciplinaEmAtraso(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlunoDisciplinaEmAtraso>()
                .HasOne(a => a.Aluno)
                .WithMany(a => a.AlunoDisciplinasEmAtraso)
                .HasForeignKey(a => a.CodigoAluno)
                .HasPrincipalKey(a=>a.Codigo);

            modelBuilder.Entity<Disciplina>()
                .HasMany(a => a.AlunoDisciplinaEmAtraso)
                .WithOne(a => a.Disciplina)
                .HasForeignKey(a => a.DisciplinaId);
        }
    }
}