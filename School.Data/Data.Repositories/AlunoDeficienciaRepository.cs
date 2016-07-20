using System.Collections.Generic;
using System.Linq;
using Core.Common.Contracts;
using School.Business.Entities;
using School.Data.Contracts.DTOs;
using School.Data.Contracts.Repositories.Interfaces;

namespace School.Data.Data.Repositories
{
    public class AlunoDeficienciaRepository : DataRepositoryBase<AlunoDeficiencia, AlunoDeficienciaIdentity>,
        IAlunoDeficienciaRepository
    {
        public IEnumerable<AlunoDeficiencia> GetDeficienciasDosAlunos(string codigo, params string[] includeEntities)
        {
            return ExecutarCodigo(a => a.CodigoAluno == codigo, includeEntities);
        }

        public IEnumerable<AlunoDeficiencia> GetAllDeficienciasDosAlunos(params string[] includeEntities)
        {
            return ExecutarCodigo(null, includeEntities);
        }

        public IEnumerable<AlunoDeficiencia> GetAlunosDeficienciasPorAno(int ano, params string[] includeEntities)
        {
            return ExecutarCodigo(a => a.Aluno.AnoLetivo == ano, includeEntities);
        }

        public IEnumerable<AlunoDeficiencia> GetDeficienciasDosAlunosPorClasse(int classe, params string[] includeEntities)
        {
            return ExecutarCodigo(a => a.Aluno.Classe == classe, includeEntities);
        }

        public IEnumerable<AlunoDeficiencia> GetDeficienciasDosAlunosPorTurma(ITurmaParameterByName turma, params string[] includeEntities)
        {
            using (var contexto = new SchoolManagementContext())
            {
                var ad = contexto.AlunoDeficiencias;
                var at = contexto.AlunoTurmas;
                var t = contexto.TurmaInfo;
                var query = 
                    from p in ad
                    join a in at
                        on p.CodigoAluno equals a.CodigoAluno
                    join ti in t 
                        on new { a.TurmaId, a.CursoId, a.TurnoId, a.AnoLetivo, a.Classe } 
                        equals 
                        new { ti.TurmaId, ti.CursoId, ti.TurnoId, ti.AnoLetivo, ti.Classe }

                    where ti.Turma.Designacao == turma.TurmaDesignacao &&
                          ti.Turno.Designacao == turma.TurnoDesignacao &&
                          ti.Curso.Abreviacao == turma.CursoAbreviacao &&
                          a.Classe == turma.Classe &&
                          a.AnoLetivo == turma.AnoLetivo
                    select p;

                return ExecutarCodigo(query, null, includeEntities);
            }
        }
    }
}