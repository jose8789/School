using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    public partial class SchoolManagementContext
    {
        public void ConfigurarAlunos(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>()
                .ToTable(nameof(Aluno), Schema.Giva)
                .Ignore(a => a.ExtensionData)
                .Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Aluno>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<Aluno>().Ignore(p => p.AlunoOwnerId);

            modelBuilder.Entity<Aluno>()
                .HasAlternateKey(a => a.Codigo)
                .HasName("Codigo");

            ConfigurarAlunoProp(modelBuilder);
            RelacionarAluno(modelBuilder);
        }

        private void ConfigurarAlunoProp(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().Property(a => a.EscolaId).HasColumnName("EscolaDeOrigem");
            modelBuilder.Entity<Aluno>().Property(a => a.ProcessoNumero).HasMaxLength(25);
            modelBuilder.Entity<Aluno>().Property(a => a.Codigo).HasMaxLength(CodigoLength);


        }
        private void RelacionarAluno(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>()
               .HasOne(e => e.Escola)
               .WithMany(e => e.Alunos)
               .HasForeignKey(a => a.AlunoId)
               .IsRequired();

            modelBuilder.Entity<Pessoa>()
                .HasOne(e => e.Aluno)
                .WithOne(e => e.Pessoa)
                .HasPrincipalKey<Pessoa>(a => a.PessoaId)
                .HasForeignKey<Aluno>(a => a.AlunoId)
                .IsRequired();
        }
    }
}