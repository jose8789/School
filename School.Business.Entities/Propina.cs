using System;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Propina : EntityBase, IIdentifiableEntity<int>, IAlunoOwnedEntity
    {
        [DataMember]
        public int PropinaId { get; set; }
        [DataMember]
        public string CodigoAluno { get; set; }
        [DataMember]
        public Aluno Aluno { get; set; }
        [DataMember]
        public double Valor { get; set; }
        [DataMember]
        public DateTime DataDePagamento { get; set; }

        [DataMember]
        public int AnoLetivo { get; set; }
        public string AlunoOwnerId => CodigoAluno;

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return PropinaId;
            }
            set { PropinaId = value; }
        }

        #endregion
    }
}
