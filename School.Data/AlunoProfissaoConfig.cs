using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    partial class SchoolManagementContext
    {
        public void ConfigurarAlunoProfissao(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlunoProfissao>()
                .ToTable(nameof(AlunoProfissao), Schema.Giva)
                .Ignore(a => a.ExtensionData)
                .Ignore(a=>a.AlunoProfissaoIdentity)
                .Ignore(a=>a.AlunoOwnerId)
                .Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<AlunoProfissao>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<AlunoProfissao>().Property(p => p.CodigoAluno).HasMaxLength(CodigoLength);
            modelBuilder.Entity<AlunoProfissao>()
                .HasKey(a => new {a.CodigoAluno, a.ProfissaoId});
            RelacionarAlunoProfissao(modelBuilder);
        }

        public void RelacionarAlunoProfissao(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profissao>()
                .HasMany(a => a.AlunoProfissoes)
                .WithOne(a => a.Profissao)
                .HasForeignKey(a => a.ProfissaoId);

            modelBuilder.Entity<AlunoProfissao>()
                .HasOne(a => a.Aluno)
                .WithMany(a => a.AlunoProfissoes)
                .HasForeignKey(a => a.CodigoAluno)
                .HasPrincipalKey(a => a.Codigo);
        }
    }
}