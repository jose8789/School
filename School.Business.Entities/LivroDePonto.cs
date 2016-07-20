using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class LivroDePonto : EntityBase, IIdentifiableEntity<int>
    {
        public LivroDePonto()
        {
            LivroDePontoDosProfessores = new List<LivroDePontoDoProfessor>();
        }
        [DataMember]
        public int LivroDePontoId { get; set; }
        [DataMember]
        public DateTime Data { get; set; }
        [DataMember]
        public Disciplina Disciplina { get; set; }
        [DataMember]
        public TurmaInfo TurmaInfo { get; set; }    

        public int EntityId
        {
            get { return LivroDePontoId; }
            set { LivroDePontoId = value; }
        }
        [DataMember]
        public List<LivroDePontoDoProfessor> LivroDePontoDosProfessores { get; set; }
        [DataMember]
        public int DisciplinaId { get; set; }

        #region TurmaInfo elements

        [DataMember]
        public int TurnoId { get; set; }

        [DataMember]
        public int Sala { get; set; }

        [DataMember]
        public int TurmaId { get; set; }
        [DataMember]
        public int CursoId { get; set; }
        [DataMember]
        public int? Classe { get; set; }
        [DataMember]
        public int AnoLetivo { get; set; }
        #endregion
    }
}
