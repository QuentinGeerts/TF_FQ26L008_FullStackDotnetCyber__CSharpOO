namespace DemoGenericite.Interfaces;

public interface IBaseEntity<T>
{
    public T Id { get; }
}
