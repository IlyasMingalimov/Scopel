namespace Scopel;
public abstract class ScopeTemplate : IDisposable
{
	private event Action<IMessageTemplate>? EmmitMessage;
	public ScopeTemplate(IEnumerable<IObjectTemplate> objs) 
	{
		foreach (var obj in objs) 
		{
			AddNewObject(obj);
		}
	}
	internal void Transmit(IMessageTemplate message) => EmmitMessage?.Invoke(message);
	internal void AddNewObject(IObjectTemplate obj) 
	{
		if (obj is ObjectSenderTemplate sender)
			sender.Sending += Transmit;

		if (obj is IObjectRecipientTemplate recipient)
			EmmitMessage += recipient.Receive;

		if (obj is ObjectEmitterTemplate emitter)
			emitter.EmitObject += AddNewObject;
	}
	public abstract void Dispose();
}
