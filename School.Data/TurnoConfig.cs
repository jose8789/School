using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarTurno(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Turno>()
                .ToTable(nameof(Turno), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Turno>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<Turno>().Property(p => p.Designacao).HasMaxLength(100);
        }

        public void RelacionarTurno(ModelBuilder modelBuilder)
        {
        }
    }
}