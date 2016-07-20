using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarObservacao(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Observacao>()
                .ToTable(nameof(Observacao), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Observacao>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<Observacao>().Property(a => a.Obs).HasMaxLength(250);
        }

        public void RelacionarObservacao(ModelBuilder modelBuilder)
        {
        }
    }
}