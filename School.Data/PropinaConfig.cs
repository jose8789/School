using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarPropinas(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Propina>()
                .ToTable(nameof(Propina), Schema.RecursoHumano)
                .Ignore(a => a.ExtensionData)
                .Ignore(a => a.EntityId)
                .Ignore(a=>a.AlunoOwnerId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Propina>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<Propina>().Property(p => p.CodigoAluno).HasMaxLength(CodigoLength);
            modelBuilder.Entity<Propina>().Property(p => p.Valor).ForSqlServerHasColumnType("money");
            RelacionarPropina(modelBuilder);
        }

        public void RelacionarPropina(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Propina>()
                .HasOne(a => a.Aluno)
                .WithMany(a => a.Propinas)
                .HasForeignKey(a => a.CodigoAluno)
                .HasPrincipalKey(a => a.Codigo);
        }
    }
}