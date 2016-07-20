using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarBusinessEntityMorada(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusinessEntityMorada>()
                .ToTable(nameof(BusinessEntityMorada), Schema.RecursoHumano)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");

            modelBuilder.Entity<BusinessEntityMorada>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            modelBuilder.Entity<BusinessEntityMorada>()
                .HasKey(a => a.BusinessEntityId);
        }

        public void RelacionarBusinessEntityMorada(ModelBuilder modelBuilder)
        {
        }
    }
}