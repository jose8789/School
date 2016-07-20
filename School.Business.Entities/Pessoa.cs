using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
   
    [DataContract]
    public class Pessoa : EntityBase, IIdentifiableEntity<int>, IPessoaOwnedEntity
    {
        public Pessoa()
        {
            Telefone = new List<Telefone>();
            Observacoes = new List<Observacao>();
        }
        [DataMember]
        public int PessoaId { get; set; }

        [DataMember]
        public string PrimeiroNome { get; set; }

        [DataMember]
        public string NomeMedio { get; set; }

        [DataMember]
        public string UltimoNome { get; set; }

        [DataMember]
        public Aluno Aluno { get; set; }

        [DataMember]
        public Bilhete Bilhete { get; set; }

        [DataMember]
        public BusinessEntity BusinessEntity { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public Password Password { get; set; }

        [DataMember]
        public Professor Professor { get; set; }
        [DataMember]
        public EncarregadoDeEducacao EncarregadoDeEducacao { get; set; }
        [DataMember]
        public List<Telefone> Telefone { get; set; }
        [DataMember]
        public List<Observacao> Observacoes { get; set; }
        [DataMember]
        public Pais Pais { get; set; }

        [DataMember]
        public int PaisId { get; set; }

        [DataMember]
        public Provincia Provincia { get; set; }

        [DataMember]
        public int ProvinciaId { get; set; }

        public int PessoaOwnerId => PessoaId;
        [DataMember]
        public string LoginName { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return PessoaId;
            }
            set
            {
                PessoaId = value;
            }
        }

        public string NomeCompleto => $"{PrimeiroNome} {NomeMedio} {UltimoNome}";

        #endregion
    }
}