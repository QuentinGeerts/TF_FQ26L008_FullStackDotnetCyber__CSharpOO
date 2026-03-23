namespace DemoGenericite.Models;

public class Paire<TKey, TValue>
{
    public TKey Key { get; init; }
    public TValue Value { get; init; }

    public override string ToString()
    {
        return $"{Key} : {Value}";
    }
}
