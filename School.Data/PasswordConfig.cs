using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarPassword(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Password>()
                .ToTable(nameof(Password), Schema.RecursoHumano)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Password>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<Password>().Property(a => a.HidenWord).HasMaxLength(35);
            modelBuilder.Entity<Password>()
                .HasKey(a => a.BusinessEntityId);
        }

        public void RelacionarPassword(ModelBuilder modelBuilder)
        {
        }
    }
}