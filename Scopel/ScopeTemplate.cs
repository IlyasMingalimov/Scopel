namespace Scopel;
public abstract class ScopeTemplate : IDisposable
{
	private event Action<IMessageTemplate>? EmmitMessage;
	public ScopeTemplate(IEnumerable<IObjectTemplate> objs) 
	{
		foreach (var obj in objs) 
		{
			if(obj is ObjectSenderTemplate sender)
				sender.Sending += Transmit;

			if(obj is IObjectRecipientTemplate recipient)
				EmmitMessage += recipient.Receive;
		}
	}
	internal void Transmit(IMessageTemplate message) => EmmitMessage?.Invoke(message);
	public abstract void Dispose();
}
