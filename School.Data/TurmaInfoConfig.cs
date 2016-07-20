using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarTurmaInfo(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TurmaInfo>()
                .ToTable(nameof(TurmaInfo), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData)
                .Ignore(a => a.EntityId)
                .Ignore(a => a.DiretorOwnerId)
                .Property(p => p.DataDeModificacao)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<TurmaInfo>().Property(p => p.Rowguid)
                .HasDefaultValueSql("newid()");
            modelBuilder.Entity<TurmaInfo>().Property(p => p.Sala).HasMaxLength(10);

            //modelBuilder.Entity<TurmaInfo>()
            //    .HasKey(a => a.TurmaInfoId);

            modelBuilder.Entity<TurmaInfo>()
                .HasKey(
                a => new {a.TurmaId, a.Classe, a.TurnoId, a.CursoId, a.AnoLetivo});

            RelacionarTurmaInfo(modelBuilder);
        }

        public void RelacionarTurmaInfo(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TurmaInfo>()
                .HasOne(a => a.Professor)
                .WithMany(a => a.TurmasInfo)
                .HasPrincipalKey(a => a.ProfessorId)
                .HasForeignKey(a => a.ProfessorId);

            modelBuilder.Entity<TurmaInfo>()
               .HasMany(a => a.Avaliacoes)
               .WithOne(a => a.TurmaInfo)
               .HasPrincipalKey(
                a => new { a.TurmaId, a.Classe, a.TurnoId, a.CursoId, a.AnoLetivo })
               .HasForeignKey(
                a => new { a.TurmaId, a.Classe, a.TurnoId, a.CursoId, a.AnoLetivo })
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}