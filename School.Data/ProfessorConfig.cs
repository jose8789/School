using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    public partial class SchoolManagementContext
    {
        public void ConfigurarProfessor(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Professor>()
                .ToTable(nameof(Professor), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Professor>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<Professor>().Ignore(p => p.FuncionarioOwnerId);

            modelBuilder.Entity<Professor>().Property(a => a.Nif).HasMaxLength(25);

            RelacionarProfessor(modelBuilder);
        }

        private void RelacionarProfessor(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .HasOne(e => e.Professor)
                .WithOne(e => e.Pessoa)
                .HasPrincipalKey<Pessoa>(a=>a.PessoaId)
                .HasForeignKey<Professor>(a=>a.ProfessorId)
                .IsRequired();
        }
    }
}