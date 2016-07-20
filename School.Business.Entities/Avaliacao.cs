using System;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Avaliacao : EntityBase, IIdentifiableEntity<int>, IAlunoOwnedEntity, IProfessorOwnedEntity
    {
        public int AvaliacaoId { get; set; }
        public string CodigoAluno { get; set; }
        public Aluno Aluno { get; set; }
        public DateTime DataDaRealizacao { get; set; }
        public int Sala { get; set; }
        public double Presenca { get; set; }
        public TipoDeAvaliacao TipoDeAvaliacao { get; set; }
        public int TipoDeAvaliacaoId { get; set; }
        public TurmaInfo TurmaInfo { get; set; }
        
        #region Interfaces implementations
        public string AlunoOwnerId { get; }
        public int EntityId { get; set; }
        public int FuncionarioOwnerId { get; } 
        #endregion

        #region turmainfo properties keys

        public int Classe { get; set; }
        public int AnoLetivo { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
        public int CursoId { get; set; }
        //public Curso Curso { get; set; }
        public int TurnoId { get; set; }
        //public Turno Turno { get; set; }
        public int TurmaId { get; set; }
        //public Turma Turma { get; set; }
        

        #endregion
    }
}