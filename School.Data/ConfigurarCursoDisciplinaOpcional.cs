using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarCursoDisciplinaOpcional(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CursoDisciplinaOpcional>()
                .ToTable(nameof(CursoDisciplinaOpcional), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData)
                .Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");

            modelBuilder.Entity<CursoDisciplinaOpcional>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            RelacionarCursoDisciplinaOpcional(modelBuilder);
        }

        public void RelacionarCursoDisciplinaOpcional(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CursoDisciplinaOpcional>()
                .HasOne(a => a.CursoDisciplina)
                .WithMany(a => a.CursoDisciplinasOpcionais)
                .HasForeignKey(a => new {a.CursoId, a.DisciplinaId})
                .HasPrincipalKey(a => new { a.CursoId, a.DisciplinaId });
        }
    }
}