using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Curso : EntityBase, IIdentifiableEntity<int>
    {
        public Curso()
        {
            CursoDisciplina = new List<CursoDisciplina>();
            CursoInfo = new List<CursoInfo>();
            Aluno = new List<Aluno>();
            TurmaInfo = new List<TurmaInfo>();
        }
        [DataMember]
        public int CursoId { get; set; }

        [DataMember]
        public string Designacao { get; set; }

        [DataMember]
        public string Abreviacao { get; set; }

        [DataMember]
        public List<CursoDisciplina> CursoDisciplina { get; set; }

        [DataMember]
        public List<CursoInfo> CursoInfo { get; set; }

        [DataMember]
        public List<Aluno> Aluno { get; set; }
        
        [DataMember]
        public List<TurmaInfo> TurmaInfo { get; set; }

        #region IIdentifiableEntity Member
        public int EntityId
        {
            get { return CursoId; }
            set { CursoId = value; }
        }
        #endregion
    }
}