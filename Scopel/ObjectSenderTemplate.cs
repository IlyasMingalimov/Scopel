namespace Scopel;
public abstract class ObjectSenderTemplate : IObjectTemplate
{
	internal event Action<IMessageTemplate>? Sending;
	public void Send<Message>(Message message) where Message : struct, IMessageTemplate => Sending?.Invoke(message);
}
