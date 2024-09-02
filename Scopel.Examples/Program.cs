using Scopel;
using Scopel.Examples.EmitClasses;
using Scopel.Examples.HelloWorld;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Hello World Example");
		HelloWorld();
		Console.WriteLine("-------------------");
		Console.WriteLine("Emit new Objects Example");
		Emit();
		Console.WriteLine("-------------------");
	}

	private static void HelloWorld() 
	{
		var sender = new HelloWordSenderObject();
		var recipient = new HelloWordRecipientObject();
		var objs = new List<IObjectTemplate> { sender, recipient };

		using (var scope = new MainScope(objs))
			sender.Hello("Jonh");

		Task.Delay(1000).Wait();
	}

	private static void Emit() 
	{
		var emitter = new Emitter();
		var starter = new Starter();
		var controller = new ParticleController();
		var objs = new List<IObjectTemplate> { emitter, starter, controller };
		using var scope = new EmitScope(objs);
		emitter.EmitObjects();
		starter.Start();
		Task.Delay(1000).Wait();
	}
}