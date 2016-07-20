using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarEnderecoEletronico(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EnderecoEletronico>()
                .ToTable(nameof(EnderecoEletronico), Schema.RecursoHumano)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<EnderecoEletronico>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<EnderecoEletronico>().Property(p => p.Email).HasMaxLength(100);
        }

        public void RelacionarEnderecoEletronico(ModelBuilder modelBuilder)
        {
        }
    }
}