using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarTurma(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Turma>()
                .ToTable(nameof(Turma), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Turma>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            modelBuilder.Entity<Turma>().Property(p => p.Designacao).HasMaxLength(100);
        }

        public void RelacionarTurma(ModelBuilder modelBuilder)
        {
        }
    }
}