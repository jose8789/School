namespace Core.Common.Contracts
{
    public interface IIdentifiableEntity { }
    public interface IIdentifiableEntity<T> : IIdentifiableEntity
    {
        //int EntityId { get; set; }
        T EntityId { get; set; }
    }
}
