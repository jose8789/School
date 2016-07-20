using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarBilhete(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bilhete>()
                .ToTable(nameof(Bilhete), Schema.RecursoHumano)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Bilhete>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            modelBuilder.Entity<Bilhete>().Property(a => a.NumeroDeBilhete).HasMaxLength(35);

            modelBuilder.Entity<Bilhete>()
                .HasKey(a => a.BusinessEntityId);
        }

        public void RelacionarBilhete(ModelBuilder modelBuilder)
        {
        }
    }
}