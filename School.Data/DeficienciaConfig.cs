using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarDeficiencia(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Deficiencia>()
                .ToTable(nameof(Deficiencia), Schema.Giva)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Deficiencia>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            modelBuilder.Entity<Deficiencia>().Property(p => p.Designacao).HasMaxLength(100);
        }

        public void RelacionarDeficiencia(ModelBuilder modelBuilder)
        {
        }
    }
}