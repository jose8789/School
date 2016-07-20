using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarTipoDeMorada(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoDeMorada>()
                .ToTable(nameof(TipoDeMorada), Schema.RecursoHumano)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<TipoDeMorada>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<TipoDeMorada>().Property(p => p.Designacao).HasMaxLength(50);
        }

        public void RelacionarTipoDeMorada(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoDeMorada>()
                .HasMany(e => e.BusinessEntityMorada)
                .WithOne(e => e.TipoDeMorada)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}