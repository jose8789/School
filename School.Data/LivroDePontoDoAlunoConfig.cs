using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    public partial class SchoolManagementContext
    {
        public void ConfigurarLivroDePontoDoAluno(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LivroDePontoDoAluno>()
                .ToTable(nameof(LivroDePontoDoAluno), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData)
                .Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<LivroDePontoDoAluno>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");
            modelBuilder.Entity<LivroDePontoDoAluno>().Property(p => p.CodigoAluno).HasMaxLength(CodigoLength);
            RelacionarLivroDePontoDoAluno(modelBuilder);
        }

        private void RelacionarLivroDePontoDoAluno(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LivroDePontoDoAluno>()
                .HasOne(a => a.Aluno)
                .WithMany(a => a.LivroDePontoDosAlunos)
                .HasPrincipalKey(a => a.Codigo)
                .HasForeignKey(a => a.CodigoAluno);

            modelBuilder.Entity<LivroDePontoDoProfessor>()
                .HasOne(a => a.LivroDePonto)
                .WithMany(a => a.LivroDePontoDosProfessores)
                .HasPrincipalKey(a => a.LivroDePontoId)
                .HasForeignKey(a => a.LivroDePontoId);
        }
    }
}