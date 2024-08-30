namespace Scopel;
public abstract class ScopeTemplate : IDisposable
{
	private event Action<MessageTemplate> EmmitMessage;
	public ScopeTemplate(IEnumerable<ObjectTemplate> objs) 
	{
		foreach (var obj in objs) 
		{
			obj.Sending += Transmit;
			EmmitMessage += obj.Receive;
		}
	}
	internal void Transmit(MessageTemplate message) => EmmitMessage?.Invoke(message);
	public abstract void Dispose();
}
