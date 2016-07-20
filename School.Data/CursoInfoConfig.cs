using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarCursoInfo(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CursoInfo>()
                .ToTable(nameof(CursoInfo), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Ignore(a => a.DiretorOwnerId)
                .Property(p => p.DataDeModificacao)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<CursoInfo>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
        }

        public void RelacionarCursoInfo(ModelBuilder modelBuilder)
        {
        }
    }
}