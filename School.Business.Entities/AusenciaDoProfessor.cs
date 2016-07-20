using System;
using System.Runtime.Serialization;
using Core.Common.Core;
using Core.Common.Contracts;

namespace School.Business.Entities
{
    [DataContract]
    public class AusenciaDoProfessor : EntityBase, IIdentifiableEntity<int>, IProfessorOwnedEntity
    {
        [DataMember]
        public int AusenciaDoProfessorId { get; set; }
        [DataMember]
        public Professor Professor { get; set; }
        [DataMember]
        public int ProfessorId { get; set; }  
        [DataMember]
        public int Tempo { get; set; }  
        [DataMember]
        public DateTime Data { get; set; }

        public int FuncionarioOwnerId => ProfessorId;

        #region IIdentifiableEntity Member
        public int EntityId
        {
            get { return AusenciaDoProfessorId; }
            set { AusenciaDoProfessorId = value; }
        }
        #endregion
    }
}
