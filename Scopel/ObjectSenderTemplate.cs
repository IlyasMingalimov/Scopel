namespace Scopel;
public abstract class ObjectSenderTemplate : IObjectTemplate
{
	internal event Action<IMessageTemplate>? Sending;
	protected void Send<Message>(Message message) where Message : struct, IMessageTemplate => Sending?.Invoke(message);
}
