using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    public partial class SchoolManagementContext
    {
        public void ConfigurarPessoa(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .ToTable(nameof(Pessoa), Schema.RecursoHumano)
                .Ignore(a => a.ExtensionData)
                .Ignore(a=>a.NomeCompleto)
                .Ignore(a => a.EntityId)
                .Ignore(p => p.PessoaOwnerId)
                .Property(p => p.DataDeModificacao)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Pessoa>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            modelBuilder.Entity<Pessoa>()
                .HasKey(a => a.PessoaId);
            ConfigPessoaProp(modelBuilder);
            RelacionarPessoa(modelBuilder);
        }

        private void ConfigPessoaProp(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .Property(a => a.NomeMedio).HasMaxLength(150);
            modelBuilder.Entity<Pessoa>()
                .Property(a => a.PrimeiroNome).HasMaxLength(72);
            modelBuilder.Entity<Pessoa>()
                .Property(a => a.UltimoNome).HasMaxLength(72);
            modelBuilder.Entity<Pessoa>()
                .Property(a => a.LoginName).HasMaxLength(15);
            modelBuilder.Entity<Pessoa>()
                .Property(a => a.Email).HasMaxLength(100);
            RelacionarPessoa(modelBuilder);
        }

        private void RelacionarPessoa(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusinessEntity>()
                .HasOne(e => e.Pessoa)
                .WithOne(e => e.BusinessEntity)
                .HasPrincipalKey<BusinessEntity>(a=>a.BusinessEntityId)
                .HasForeignKey<Pessoa>(a=>a.PessoaId);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.Observacoes)
                .WithOne(e => e.Pessoa)
                .HasForeignKey(a => a.PessoaId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pessoa>()
                .HasOne(e => e.Bilhete)
                .WithOne(e => e.Pessoa)
                .HasPrincipalKey<Pessoa>(a=>a.PessoaId)
                .HasForeignKey<Bilhete>(a=>a.BusinessEntityId)
                .IsRequired();

            modelBuilder.Entity<Pessoa>()
                .HasOne(e => e.Pais)
                .WithMany(e => e.Pessoas)
                .HasForeignKey(a => a.PaisId)
                .IsRequired();

            modelBuilder.Entity<Pessoa>()
                .HasOne(e => e.Provincia)
                .WithMany(e => e.Pessoas)
                .HasForeignKey(a => a.ProvinciaId)
                .IsRequired();

            modelBuilder.Entity<Pessoa>()
                .HasOne(e => e.Password)
                .WithOne(e => e.Pessoa)
                .HasPrincipalKey<Pessoa>(a=>a.PessoaId)
                .HasForeignKey<Password>(a=>a.BusinessEntityId)
                .IsRequired();

            modelBuilder.Entity<Pessoa>()
                .HasOne(e => e.EncarregadoDeEducacao)
                .WithOne(e => e.Pessoa)
                .HasPrincipalKey<Pessoa>(a=>a.PessoaId)
                .HasForeignKey<EncarregadoDeEducacao>(a=>a.EncarregadoDeEducacaoId)
                .IsRequired();

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.Telefone)
                .WithOne(e => e.Pessoa)
                .HasForeignKey(a => a.BusinessEntityId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}