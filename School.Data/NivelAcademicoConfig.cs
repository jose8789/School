using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarNivelAcademico(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NivelAcademico>()
                .ToTable(nameof(NivelAcademico), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<NivelAcademico>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<NivelAcademico>().Property(p => p.Designacao).HasMaxLength(100);
        }

        public void RelacionarNivelAcademico(ModelBuilder modelBuilder)
        {
        }
    }
}