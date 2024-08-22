namespace Scopel;
public class ScopeTemplate
{
    private event Action<MessageTemplate> EmmitMessage;

    internal void AddObject(ObjectTemplate obj)
    {
        EmmitMessage += obj.ReceiveMessage;
        obj.SubscribeToMessage(SendMessage);
    }

    internal void AddMessage(MessageTemplate message)
    {
        EmmitMessage.Invoke(message);
    }

    internal void SendMessage(MessageTemplate message) 
    { 
        AddMessage(message);
    }
}
