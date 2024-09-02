namespace Scopel.Examples.EmitClasses;
public class EmitScope : ScopeTemplate
{
	public EmitScope(IEnumerable<IObjectTemplate> objs) : base(objs){}
	public override void Dispose() { }
}
public struct StartMessage : IMessageTemplate { }
public struct CreateMessage : IMessageTemplate { public string ParticleName; }
public class Particle : ObjectSenderTemplate, IObjectRecipientTemplate
{
	public string ParticleName { init; get; }
	public Particle(string particleName) => ParticleName = particleName;
	public void Receive(IMessageTemplate message)
	{
		if (message is StartMessage) 
			Send(new CreateMessage { ParticleName = ParticleName });
	}
}
public class Emitter : ObjectEmitterTemplate
{ 
	public void EmitObjects() 
	{
		Emit(new Particle("1"));
		Emit(new Particle("2"));
		Emit(new Particle("3"));
		Emit(new Particle("4"));
	}
}
public class Starter : ObjectSenderTemplate
{
	public void Start() => Send(new StartMessage());
}
public class ParticleController : IObjectRecipientTemplate
{
	public void Receive(IMessageTemplate message)
	{
		if(message is CreateMessage createMessage)
			Console.WriteLine($"{createMessage.ParticleName} created");
	}
}
