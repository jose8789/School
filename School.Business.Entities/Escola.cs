using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Escola : EntityBase, IIdentifiableEntity<int>
    {
        public Escola()
        {
            Alunos = new List<Aluno>();
        }
        [DataMember]
        public int EscolaId { get; set; }
        [DataMember]
        public string Designacao { get; set; }
        [DataMember]
        public List<Aluno> Alunos { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return EscolaId;
            }
            set { EscolaId = value; }
        }

        #endregion
    }
}
