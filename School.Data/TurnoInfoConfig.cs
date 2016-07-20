using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarTurnoInfo(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TurnoInfo>()
                .ToTable(nameof(TurnoInfo), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData)
                .Ignore(a => a.EntityId)
                .Ignore(a => a.CoordenadorOwnerId)
                .Property(p => p.DataDeModificacao)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<TurnoInfo>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            modelBuilder.Entity<TurnoInfo>()
                .HasKey(a => a.TurnoInfoId);
            modelBuilder.Entity<TurnoInfo>()
                .HasAlternateKey(a => new {a.ProfessorId, a.TurnoId, a.AnoLetivo});
        }

        public void RelacionarTurnoInfo(ModelBuilder modelBuilder)
        {
        }
    }
}