using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarTipoDeAvaliacao(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoDeAvaliacao>()
                .ToTable(nameof(TipoDeAvaliacao), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<TipoDeAvaliacao>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<TipoDeAvaliacao>().Property(p => p.Tipo).HasMaxLength(100);
        }

        public void RelacionarTipoDeAvaliacao(ModelBuilder modelBuilder)
        {
        }
    }
}