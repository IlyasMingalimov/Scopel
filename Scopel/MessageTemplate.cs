namespace Scopel;
public class MessageTemplate<T> : IMessageTemplate
{
    public MessageTemplate(T value)
    { 
        Value = value;
    }

    public T Value { get; private set; }
}

public interface IMessageTemplate 
{ 

}