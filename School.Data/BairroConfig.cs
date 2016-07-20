using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarBairro(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bairro>()
                .ToTable(nameof(Bairro),Schema.RecursoHumano)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Bairro>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<Bairro>().Property(p => p.Designacao).HasMaxLength(placesLength);
   
            RelacionarBairro(modelBuilder);
        }

        public void RelacionarBairro(ModelBuilder modelBuilder)
        {
        }
    }
}