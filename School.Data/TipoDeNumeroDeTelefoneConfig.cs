using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarTipoDeNumeroDeTelefone(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoDeNumeroDeTelefone>()
                .ToTable(nameof(TipoDeNumeroDeTelefone), Schema.RecursoHumano)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<TipoDeNumeroDeTelefone>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<TipoDeNumeroDeTelefone>().Property(p => p.Designacao).HasMaxLength(25);
        }

        public void RelacionarTipoDeNumeroDeTelefone(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoDeNumeroDeTelefone>()
                .HasMany(e => e.Telefone)
                .WithOne(e => e.TipoDeNumeroDeTelefone)
                .IsRequired();
        }
    }
}