using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarDisciplinaInfo(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DisciplinaInfo>()
                .ToTable(nameof(DisciplinaInfo), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Ignore(a=>a.CoordenadorOwnerId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<DisciplinaInfo>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
        }

        public void RelacionarDisciplinaInfo(ModelBuilder modelBuilder)
        {
        }
    }
}