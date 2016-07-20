using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarCursoDisciplina(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CursoDisciplina>()
                .ToTable(nameof(CursoDisciplina), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData)
                .Ignore(a=>a.CursoDisciplinaIdentity)
                .Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");

            modelBuilder.Entity<CursoDisciplina>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            modelBuilder.Entity<CursoDisciplina>()
                .HasKey(a => new {a.CursoId, a.DisciplinaId});
            RelacionarCursoDisciplina(modelBuilder);
        }

        public void RelacionarCursoDisciplina(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CursoDisciplina>()
                .HasOne(a => a.TipoDeFormacao)
                .WithMany(a => a.CursoDisciplinas)
                .HasForeignKey(a => a.TipoDeFormacaoId);
        }
    }
}