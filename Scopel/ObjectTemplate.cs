namespace Scopel;
public abstract class ObjectTemplate
{
	internal event Action<MessageTemplate> Sending;
	public void Send(MessageTemplate message) => Sending?.Invoke(message);
	public abstract void Receive(MessageTemplate message);
}