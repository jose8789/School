using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Professor : EntityBase, IIdentifiableEntity<int>, IProfessorOwnedEntity
    {
        public Professor()
        {
            ProfessorTurma = new List<ProfessorTurma>();
            ProfessorAreasDeFormacao = new List<ProfessorAreaDeFormacao>();
            CursoInfo = new List<CursoInfo>();
            TurmasInfo = new List<TurmaInfo>();
            TurnoInfo = new List<TurnoInfo>();
            LivroDePontoDosProfessores = new List<LivroDePontoDoProfessor>();
        }
        [DataMember]
        public int ProfessorId { get; set; }

        [DataMember]
        public string Nif { get; set; }

        [DataMember]
        public int? NivelAcademicoId { get; set; }

        [DataMember]
        public int? AnoDeIngresso { get; set; }

        [DataMember]
        public byte[] Foto { get; set; }

        [DataMember]
        public DateTime? DataDeNascimento { get; set; }

        [DataMember]
        public Pessoa Pessoa { get; set; }    

        [DataMember]
        public List<ProfessorAreaDeFormacao> ProfessorAreasDeFormacao { get; set; }

        [DataMember]
        public List<CursoInfo> CursoInfo { get; set; }

        [DataMember]
        public List<DisciplinaInfo> DisciplinaInfo { get; set; }

        [DataMember]
        public NivelAcademico NivelAcademico { get; set; }

        [DataMember]
        public List<ProfessorTurma> ProfessorTurma { get; set; }

        [DataMember]
        public List<TurnoInfo> TurnoInfo { get; set; }
        [DataMember]
        public List<TurmaInfo> TurmasInfo { get; set; }
        [DataMember]
        public List<LivroDePontoDoProfessor> LivroDePontoDosProfessores { get; set; }

        public int FuncionarioOwnerId => ProfessorId;

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return ProfessorId;
            }
            set { ProfessorId = value; }
        }
        #endregion
    }
}