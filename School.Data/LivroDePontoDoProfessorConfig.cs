using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    public partial class SchoolManagementContext
    {
        public void ConfigurarLivroDePontoDoProfessor(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LivroDePontoDoProfessor>()
                .ToTable(nameof(LivroDePontoDoProfessor), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData)
                .Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<LivroDePontoDoProfessor>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            RelacionarLivroDePontoDoProfessor(modelBuilder);
        }

        private void RelacionarLivroDePontoDoProfessor(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LivroDePontoDoProfessor>()
                .HasOne(a => a.Professor)
                .WithMany(a => a.LivroDePontoDosProfessores)
                .HasPrincipalKey(a => a.ProfessorId)
                .HasForeignKey(a => a.ProfessorId);

            modelBuilder.Entity<LivroDePontoDoProfessor>()
                .HasOne(a => a.LivroDePonto)
                .WithMany(a => a.LivroDePontoDosProfessores)
                .HasPrincipalKey(a => a.LivroDePontoId)
                .HasForeignKey(a => a.LivroDePontoId);
        }
    }
}