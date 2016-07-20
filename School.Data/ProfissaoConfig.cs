using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarProfissao(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profissao>()
                .ToTable(nameof(Profissao), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Profissao>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            modelBuilder.Entity<Profissao>().Property(p => p.Designacao).HasMaxLength(100);
        }

        public void RelacionarProfissao(ModelBuilder modelBuilder)
        {
        }
    }
}