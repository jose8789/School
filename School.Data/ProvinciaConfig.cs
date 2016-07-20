using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarProvincia(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Provincia>()
                .ToTable(nameof(Provincia), Schema.RecursoHumano)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Provincia>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            modelBuilder.Entity<Provincia>().Property(a => a.Designacao).HasMaxLength(35);
        }

        public void RelacionarProvincia(ModelBuilder modelBuilder)
        {
        }
    }
}