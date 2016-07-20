using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigAreaDeFormacao(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AreaDeFormacao>()
                .ToTable(nameof(AreaDeFormacao), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");

            modelBuilder.Entity<AreaDeFormacao>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            modelBuilder.Entity<AreaDeFormacao>().Property(p => p.Designacao).HasMaxLength(75);
        }

        public void RelacionarAreaDeFormacao(ModelBuilder modelBuilder)
        {
        }
    }
}