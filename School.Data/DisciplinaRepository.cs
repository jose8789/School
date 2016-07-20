using System.Collections.Generic;
using System.Linq;
using School.Business.Entities;
using School.Data.Contracts.Repositories.Interfaces;

namespace School.Data.Data.Repositories
{
    public class DisciplinaRepository : DataRepositoryBase<Disciplina, int>, IDisciplinaRepository
    {
        public IEnumerable<Disciplina> GetDisciplinasDoCurso(int cursoId, params string[] includeEntities)
        {
            using (var contexto = new SchoolManagementContext())
            {
                var discTb = contexto.CursoDisciplina;
                var query = discTb.Where(a => a.CursoId == cursoId).Select(a => a.Disciplina);
                return ExecutarCodigo(query,null, includeEntities);
            }
        }

        public IEnumerable<Disciplina> GetDisciplinasDoCurso(string cursoAbr, params string[] includeEntities)
        {
            using (var contexto = new SchoolManagementContext())
            {
                var discTb = contexto.CursoDisciplina;
                var query = discTb.Where(a => a.Curso.Abreviacao == cursoAbr).Select(a => a.Disciplina);
                return ExecutarCodigo(query, null, includeEntities);
            }
        }

        public IEnumerable<Disciplina> GetDisciplinasDoCursoPorTipo(int cursoId, string tipoDeFormacao, params string[] includeEntities)
        {
            using (var contexto = new SchoolManagementContext())
            {
                var discTb = contexto.CursoDisciplina;
                var query = discTb.Where(a => a.CursoId == cursoId && a.TipoDeFormacao.Designacao == tipoDeFormacao)
                    .Select(a => a.Disciplina);
                return ExecutarCodigo(query, null, includeEntities);
            }
        }

        public IEnumerable<Disciplina> GetDisciplinasDoCursoPorTipo(string cursoAbrev, string tipoDeFormacao, params string[] includeEntities)
        {
            using (var contexto = new SchoolManagementContext())
            {
                var discTb = contexto.CursoDisciplina;
                var query = discTb.Where(a => a.Curso.Abreviacao == cursoAbrev && a.TipoDeFormacao.Designacao == tipoDeFormacao)
                    .Select(a => a.Disciplina);
                return ExecutarCodigo(query, null, includeEntities);
            }
        }
    }
}