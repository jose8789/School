using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarComuna(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comuna>()
                .ToTable(nameof(Comuna), Schema.RecursoHumano)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Comuna>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            modelBuilder.Entity<Comuna>().Property(a => a.Designacao).HasMaxLength(35);

            RelacionarComuna(modelBuilder);
        }

        public void RelacionarComuna(ModelBuilder modelBuilder)
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