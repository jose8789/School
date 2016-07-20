using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarEscola(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Escola>().ToTable(nameof(Escola), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Escola>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<Escola>().Property(p => p.Designacao).HasMaxLength(100);
        }

        public void RelacionarEscola(ModelBuilder modelBuilder)
        {
        }
    }
}