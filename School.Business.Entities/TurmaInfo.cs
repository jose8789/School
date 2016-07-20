using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class TurmaInfo : EntityBase, IIdentifiableEntity<int>, IDiretorOwnedEntity
    {
        public TurmaInfo()
        {
            AlunoTurmas = new List<AlunoTurma>();
            ProfessorTurmas = new List<ProfessorTurma>();
            AlunoTurmas = new List<AlunoTurma>();
            Avaliacoes = new List<Avaliacao>();
            LivroDePontos = new List<LivroDePonto>();
        }
        [DataMember]
        public int TurmaId { get; set; }

        [DataMember]
        public int CursoId { get; set; }

        [DataMember]
        public int AnoLetivo { get; set; }

        [DataMember]
        public int Classe { get; set; }

        [DataMember]
        public int LocalizacaoId { get; set; }

        [DataMember]
        public int? ProfessorId { get; set; }
            
        [DataMember]
        public int TurnoId { get; set; }

        [DataMember]
        public int Sala { get; set; }

        [DataMember]
        public Curso Curso { get; set; }
        
        [DataMember]
        public Localizacao Localizacao { get; set; }

        [DataMember]
        public Turma Turma { get; set; }

        [DataMember]
        public Professor Professor { get; set; }

        [DataMember]
        public Turno Turno { get; set; }
        [DataMember]
        public List<AlunoTurma> AlunoTurmas { get; set; }
        [DataMember]
        public List<ProfessorTurma> ProfessorTurmas { get; set; }
        [DataMember]
        public List<LivroDePonto> LivroDePontos { get; set; }

        public List<Avaliacao> Avaliacoes { get; set; }
            
        public int DiretorOwnerId => ProfessorId ?? 0;

        #region IIdentifiableEntity Member

        #endregion

        public int EntityId { get; set; }
    }
}