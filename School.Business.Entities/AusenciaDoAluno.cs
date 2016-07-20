using System;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class AusenciaDoAluno : EntityBase, IIdentifiableEntity<int>, IAlunoOwnedEntity
    {
        [DataMember]
        public int AusenciaDoAlunoId { get; set; }
        [DataMember]
        public Aluno Aluno { get; set; }
        [DataMember]
        public string CodigoAluno { get; set; }
        [DataMember]
        public int Tempo { get; set; }
        [DataMember]
        public DateTime Data { get; set; }

        public string AlunoOwnerId => CodigoAluno;
        #region IIdentifiableEntity Member
        public int EntityId
        {
            get { return AusenciaDoAlunoId; }
            set { AusenciaDoAlunoId = value; }
        } 
        #endregion
    }
}
