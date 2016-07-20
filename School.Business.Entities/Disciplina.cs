using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Disciplina : EntityBase, IIdentifiableEntity<int>
    {
        public Disciplina()
        {
            AlunoDisciplinaEmAtraso = new List<AlunoDisciplinaEmAtraso>();
            Avaliacao = new List<Avaliacao>();
            CursoDisciplina = new List<CursoDisciplina>();
            DisciplinaInfo = new List<DisciplinaInfo>();
            ProfessorTurma = new List<ProfessorTurma>();
            LivroDePontos = new List<LivroDePonto>();
        }
        [DataMember]
        public int DisciplinaId { get; set; }

        [DataMember]
        public string Designacao { get; set; }
        [DataMember]
        public List<AlunoDisciplinaEmAtraso> AlunoDisciplinaEmAtraso { get; set; }

        [DataMember]
        public List<Avaliacao> Avaliacao { get; set; }

        [DataMember]
        public List<CursoDisciplina> CursoDisciplina { get; set; }

        [DataMember]
        public List<DisciplinaInfo> DisciplinaInfo { get; set; }

        [DataMember]
        public List<ProfessorTurma> ProfessorTurma { get; set; }
        [DataMember]
        public string Code { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return DisciplinaId;
            }
            set { DisciplinaId = value; }
        }
        [DataMember]
        public List<LivroDePonto> LivroDePontos { get; set; }

        #endregion
    }
}