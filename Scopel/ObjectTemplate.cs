namespace Scopel;
public abstract class ObjectTemplate
{
    event Action<MessageTemplate> SendMessageFunc;
    public abstract void ReceiveMessage(MessageTemplate message);
    public void SendMessage(MessageTemplate message) 
    {
        SendMessageFunc?.Invoke(message);
    }

    internal void SubscribeToMessage(Action<MessageTemplate> func) 
    {
        SendMessageFunc += func;
    }
}
