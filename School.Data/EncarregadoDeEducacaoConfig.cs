using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarEncarregadoDeEducacao(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EncarregadoDeEducacao>()
                .ToTable(nameof(EncarregadoDeEducacao), Schema.RecursoHumano)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<EncarregadoDeEducacao>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            RelacionarEncarregadoDeEducacao(modelBuilder);
        }

        public void RelacionarEncarregadoDeEducacao(ModelBuilder modelBuilder)
        {

        }
    }
}