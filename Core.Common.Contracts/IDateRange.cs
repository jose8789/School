using System;

namespace Core.Common.Contracts
{
    public interface IDateRange
    {
        DateTime DataInicial { get; set; }
        DateTime DataFinal { get; set; }
    }
}
