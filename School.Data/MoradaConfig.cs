using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        private const int placesLength = 75;
        public void ConfigurarMorada(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Morada>()
                .ToTable(nameof(Morada), Schema.RecursoHumano)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Morada>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<Morada>().Property(p => p.MoradaPrincipal).HasMaxLength(placesLength);
            modelBuilder.Entity<Morada>().Property(p => p.MoradaSecundaria).HasMaxLength(placesLength);
            modelBuilder.Entity<Morada>().Property(p => p.Cidade).HasMaxLength(placesLength);

            modelBuilder.Entity<Morada>()
                .Property(e => e.CodigoPostal)
                .HasMaxLength(10);

            RelacionarMorada(modelBuilder);
        }

        public void RelacionarMorada(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Morada>()
                .HasMany(e => e.BusinessEntityMorada)
                .WithOne(e => e.Morada)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}