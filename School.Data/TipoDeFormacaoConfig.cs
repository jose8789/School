using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    public partial class SchoolManagementContext
    {
        public void ConfigurarTipoDeFormacao(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoDeFormacao>()
                .ToTable(nameof(TipoDeFormacao), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData)
                .Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<TipoDeFormacao>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            RelacionarTipoDeFormacao(modelBuilder);
        }

        private void RelacionarTipoDeFormacao(ModelBuilder modelBuilder)
        {
        }
    }
}