using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;
using School.Data.Contracts.DTOs;

namespace School.Business.Entities
{
    [DataContract]
    public class CursoDisciplina : EntityBase, IIdentifiableEntity<CursoDisciplinaIdentity>
    {
        [DataMember]
        public int DisciplinaId { get; set; }

        [DataMember]
        public int CursoId { get; set; }

        [DataMember]
        public int Classe { get; set; }

        [DataMember]
        public int? CargaHoraria { get; set; }

        [DataMember]
        public TipoDeFormacao TipoDeFormacao { get; set; }

        [DataMember]
        public int TipoDeFormacaoId { get; set; }


        [DataMember]
        public Curso Curso { get; set; }

        [DataMember]
        public Disciplina Disciplina { get; set; }

        [DataMember]
        public CursoDisciplinaIdentity CursoDisciplinaIdentity { get; set; }

        #region IIdentifiableEntity Member

        public CursoDisciplinaIdentity EntityId
        {
            get
            {
                return CursoDisciplinaIdentity ?? new CursoDisciplinaIdentity
                {
                    DisciplinaId = DisciplinaId,
                    CursoId = CursoId
                };
            }
            set { CursoDisciplinaIdentity = value; }
        }
        [DataMember]
        public List<CursoDisciplinaOpcional> CursoDisciplinasOpcionais { get; set; }

        #endregion
    }
}