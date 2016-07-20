using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarTelefone(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Telefone>()
                .ToTable(nameof(Telefone), Schema.RecursoHumano)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Telefone>().Property(a => a.TipoDeNumeroDeTelefoneId).HasColumnName("Tipo");
            modelBuilder.Entity<Telefone>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<Telefone>().Property(p => p.NumeroDeTelefone).HasMaxLength(25);
        }

        public void RelacionarTelefone(ModelBuilder modelBuilder)
        {
        }
    }
}