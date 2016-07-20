using System.Collections.Generic;

namespace Core.Common.Contracts
{
    public interface IPropinaRepositoryHelper<out T> : IDataRepositoryHelper where T : class, new()
    {
        IEnumerable<T> GetUltimasPropinas(int ano, string codigo, params string[] include);
        IEnumerable<T> GetUltimasPropinas(int ano, params string[] include);
    }
}
