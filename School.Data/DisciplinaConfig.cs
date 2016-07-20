using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarDisciplina(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Disciplina>()
                .ToTable(nameof(Disciplina), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Disciplina>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<Disciplina>().Property(p => p.Designacao).HasMaxLength(100);
            modelBuilder.Entity<Disciplina>().HasAlternateKey(a => a.Code);
            modelBuilder.Entity<Disciplina>().Property(a => a.Code).HasMaxLength(10);
        }

        public void RelacionarDisciplina(ModelBuilder modelBuilder)
        {
        }
    }
}