using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarLocalizacao(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Localizacao>()
                .ToTable(nameof(Localizacao), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Localizacao>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            modelBuilder.Entity<Localizacao>().Property(p => p.Local).HasMaxLength(75);
        }

        public void RelacionarLocalizacao(ModelBuilder modelBuilder)
        {
        }
    }
}