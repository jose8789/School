using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarCurso(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>()
                .ToTable(nameof(Curso), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Curso>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            modelBuilder.Entity<Curso>().Property(c => c.Abreviacao).HasMaxLength(10);

            modelBuilder.Entity<Curso>().Property(c => c.Designacao).HasMaxLength(35);
        }

        public void RelacionarCurso(ModelBuilder modelBuilder)
        {
        }
    }
}