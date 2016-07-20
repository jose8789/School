using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class EncarregadoDeEducacao : EntityBase, IIdentifiableEntity<int>
    {
        public EncarregadoDeEducacao()
        {
            EncarregadoPrincipalFor = new List<Aluno>();
            EncarregadoSecundarioFor = new List<Aluno>();
        }
        [DataMember]
        public int EncarregadoDeEducacaoId { get; set; }
        [DataMember]
        public Pessoa Pessoa { get; set; }
        [DataMember]
        public List<Aluno> EncarregadoPrincipalFor { get; set; }
        [DataMember]
        public List<Aluno> EncarregadoSecundarioFor { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return EncarregadoDeEducacaoId;
            }
            set { EncarregadoDeEducacaoId = value; }
        }

        #endregion
    }
}
