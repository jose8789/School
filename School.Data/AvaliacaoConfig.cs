using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarAvaliacao(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avaliacao>()
                .ToTable(nameof(Avaliacao), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData).Ignore(a => a.EntityId)
                .Ignore(a => a.FuncionarioOwnerId)
                .Ignore(a => a.AlunoOwnerId)
                .Property(p => p.DataDeModificacao)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Avaliacao>()
                .Property(p => p.Rowguid)
                .HasDefaultValueSql("newid()");

            modelBuilder.Entity<Avaliacao>()
                .Property(p => p.Presenca)
                .HasDefaultValueSql("0");
            modelBuilder.Entity<Avaliacao>().Property(p => p.CodigoAluno).HasMaxLength(CodigoLength).IsRequired();
            modelBuilder.Entity<Avaliacao>().Property(p => p.Classe).IsRequired();
            modelBuilder.Entity<Avaliacao>().Property(p => p.Sala).HasMaxLength(20);
            RelacionarAvaliacao(modelBuilder);
        }

        public void RelacionarAvaliacao(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Avaliacao>()
                .HasOne(e => e.TipoDeAvaliacao)
                .WithMany(e => e.Avaliacao)
                .IsRequired()
                .HasForeignKey(a => a.TipoDeAvaliacaoId);

            modelBuilder.Entity<Avaliacao>()
                .HasOne(a => a.Aluno)
                .WithMany(a => a.Avaliacoes)
                .HasForeignKey(a => a.CodigoAluno)
                .HasPrincipalKey(a => a.Codigo);
        }
    }
}