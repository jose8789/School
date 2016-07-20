using System;
using School.Business.Entities;

namespace School.Data.Contracts.DTOs
{
    public class AlunoDividaInfo
    {
        public Aluno Aluno { get; set; }
        public Propina Propina { get; set; }
        public DateTime UltimoPagamento { get; set; }
    } 
}
