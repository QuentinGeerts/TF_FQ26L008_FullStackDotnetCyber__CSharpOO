namespace DemoExceptions.Exceptions;

public class QuentinException : ArgumentException
{
    public string Value { get; init; }
    public QuentinException()
    {
    }

    public QuentinException(string? message) : base(message)
    {
    }

    public QuentinException(string? message, string value)
       : this($"{message}. '${value}'")
    {
        Value = value;
    }
}
