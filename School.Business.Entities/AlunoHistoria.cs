using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class AlunoHistoria : EntityBase, IIdentifiableEntity<string>, IAlunoOwnedEntity
    {
        [DataMember]    
        public int AlunoHistoryId { get; set; }

        [DataMember]
        public string CodigoAluno { get; set; }

        [DataMember]
        public int LocalizacaoId { get; set; }

        [DataMember]
        public int? Numero { get; set; }

        [DataMember]
        public Localizacao Localizacao { get; set; }

        [DataMember]
        public Aluno Aluno { get; set; }

        public string AlunoOwnerId => CodigoAluno;

        #region IIdentifiableEntity Members
        public string EntityId
        {
            get { return CodigoAluno; }
            set { CodigoAluno = value; }
        }
        #endregion
        #region TurmaInfo elements

        [DataMember]
        public int TurnoId { get; set; }

        [DataMember]
        public string Sala { get; set; }

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