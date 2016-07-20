using System;
using System.Collections.Generic;
using System.Linq;
using Core.Common.Contracts;
using School.Business.Entities;
using School.Data.Contracts.Repositories.Interfaces;

namespace School.Data.Data.Repositories
{
    public class AvaliacaoRepository : DataRepositoryBase<Avaliacao, int>, IAvaliacaoRepository
    {
        public IEnumerable<Avaliacao> GetAvaliacoesPorAluno(string codigo, DateTime date1, DateTime date2,
            params string[] includeEntities)
        {
            return
                ExecutarCodigo(
                    a => a.CodigoAluno == codigo && a.DataDaRealizacao.Date >= date1 && a.DataDaRealizacao <= date2,
                    includeEntities);
        }

        public IEnumerable<Avaliacao> GetAvaliacoesPorTurma(ITurmaParameterByName turma, DateTime date1, DateTime date2,
            params string[] includeEntities)
        {
            using (var contexto = new SchoolManagementContext())
            {
                var avaliacoes = contexto.Avaliacoes;
                var turmas = contexto.TurmaInfo;
                var query = from av in avaliacoes
                    join t in turmas
                        on new {av.TurmaId, av.CursoId, av.TurnoId, av.AnoLetivo, av.Classe}
                        equals
                        new {t.TurmaId, t.CursoId, t.TurnoId, t.AnoLetivo, t.Classe}
                    select av;
                return ExecutarCodigo(query, null, includeEntities);
            }
        }

        public IEnumerable<Avaliacao> GetAvaliacoesPorAlunoEDisciplina(string codigo, DateTime date1, DateTime date2, string disciplinaCode, params string[] includeEntities)
        {
            return
                ExecutarCodigo(
                    a =>
                        a.CodigoAluno == codigo && a.Disciplina.Code == disciplinaCode && a.DataDaRealizacao.Date >= date1 &&
                        a.DataDaRealizacao <= date2,
                    includeEntities);
        }

        public IEnumerable<Avaliacao> GetAvaliacoesPorTurmaEDisciplina(ITurmaParameterByName turma, DateTime date1,
            DateTime date2, string disciplinaCode,
            params string[] includeEntities)
        {
            using (var contexto = new SchoolManagementContext())
            {
                var avaliacoes = contexto.Avaliacoes;
                var turmas = contexto.TurmaInfo;
                var disciplinas = contexto.Disciplinas;
                var query = 
                    from av in avaliacoes
                    from d in disciplinas
                    join t in turmas 
                    on new { av.TurmaId, av.Classe, av.TurnoId, av.CursoId, av.AnoLetivo } equals new { t.TurmaId, t.Classe, t.TurnoId, t.CursoId, t.AnoLetivo}
                where av.DisciplinaId == d.DisciplinaId
                          && d.Code == disciplinaCode
                    select av;
                return ExecutarCodigo(query, null, includeEntities);
            }
        }
    }
}