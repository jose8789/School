using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarPais(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pais>()
                .ToTable(nameof(Pais), Schema.RecursoHumano)
                .Ignore(a => a.ExtensionData)
                .Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Pais>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            modelBuilder.Entity<Pais>().Property(a => a.Designacao).HasMaxLength(35);
            RelacionarPais(modelBuilder);
        }

        public void RelacionarPais(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pais>()
                .HasMany(e => e.Provincia)
                .WithOne(e => e.Pais)
                .HasForeignKey(a => a.PaisId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}