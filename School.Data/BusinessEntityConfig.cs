using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarBusinessEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusinessEntity>()
                .ToTable(nameof(BusinessEntity), Schema.RecursoHumano)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<BusinessEntity>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
        }

        public void RelacionarBusinessEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.BusinessEntityMorada)
                .WithOne(e => e.BusinessEntity)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}