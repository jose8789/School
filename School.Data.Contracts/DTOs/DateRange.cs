using System;
using Core.Common.Contracts;

namespace School.Data.Contracts.DTOs
{
    public class DateRange : IDateRange
    {
        public DateTime DataInicial { get; set; }

        private DateTime _datafinal;
        public DateTime DataFinal
        {
            get { return _datafinal; }
            set
            {
                if (DataInicial > value)
                    throw new ArgumentOutOfRangeException($"A data final ({value}) deve ser maior que a data inicial{DataInicial}");
                _datafinal = value;
            }
        }
    }
}
