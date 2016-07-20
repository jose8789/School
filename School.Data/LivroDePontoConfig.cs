using Microsoft.EntityFrameworkCore;
using School.Business.Entities;
using School.Data.Type;

namespace School.Data
{
    public partial class SchoolManagementContext
    {
        public void ConfigurarLivroDePonto(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LivroDePonto>()
                .ToTable(nameof(LivroDePonto), Schema.AreaPedagogica)
                .Ignore(a => a.ExtensionData)
                .Ignore(a => a.EntityId)
                .Property(p => p.DataDeModificacao)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<LivroDePonto>().Property(a => a.Sala).HasMaxLength(SalaLength);
            modelBuilder.Entity<LivroDePonto>().Property(p => p.Rowguid).HasDefaultValueSql("newid()");

            RelacionarLivroDePonto(modelBuilder);
        }

        private void RelacionarLivroDePonto(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LivroDePonto>()
                .HasOne(a => a.Disciplina)
                .WithMany(a => a.LivroDePontos)
                .HasPrincipalKey(a => a.DisciplinaId)
                .HasForeignKey(a => a.DisciplinaId);

            modelBuilder.Entity<TurmaInfo>()
                .HasMany(a => a.LivroDePontos)
                .WithOne(a => a.TurmaInfo)
                .HasForeignKey(a => new { a.TurmaId, a.CursoId, a.TurnoId, a.AnoLetivo, a.Classe })
                .HasPrincipalKey(a => new { a.TurmaId, a.CursoId, a.TurnoId, a.AnoLetivo, a.Classe });
        }
    }
}