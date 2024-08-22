namespace Scopel;
public abstract class ObjectTemplate
{
    private event Action<MessageTemplate> SendMessageFunc;
    internal void SubscribeToMessage(Action<MessageTemplate> func) => SendMessageFunc += func;
    public abstract void ReceiveMessage(MessageTemplate message);
    public void SendMessage(MessageTemplate message) => SendMessageFunc?.Invoke(message);
}
