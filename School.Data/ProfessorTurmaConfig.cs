using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarProfessorTurma(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProfessorTurma>()
                .ToTable(nameof(ProfessorTurma), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData)
                //.Ignore(a=>a.ProfessorTurmaIdentity)
                .Ignore(a=>a.FuncionarioOwnerId)
                .Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<ProfessorTurma>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<ProfessorTurma>()
                .HasAlternateKey(a => new {a.TurmaId, a.CursoId, a.TurnoId, a.AnoLetivo, a.Classe, a.Sala, a.DisciplinaId});
        }

        public void RelacionarProfessorTurma(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProfessorTurma>()
                .HasOne(a => a.Professor)
                .WithMany(a => a.ProfessorTurma)
                .HasForeignKey(a => a.ProfessorId)
                .HasPrincipalKey(a => a.ProfessorId);

            //modelBuilder.Entity<TurmaInfo>()
            //    .HasMany(a => a.ProfessorTurmas)
            //    .WithOne(a => a.TurmaInfo)
            //    .HasForeignKey(a => new { a.TurmaId, a.CursoId, a.TurnoId, a.AnoLetivo, a.Classe,a.Sala })
            //    .HasPrincipalKey(a => new { a.TurmaId,a.CursoId, a.TurnoId, a.AnoLetivo, a.Classe,a.Sala });
        }
    }
}