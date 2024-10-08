using Scopel;
using Scopel.Examples.EmitClasses;
using Scopel.Examples.HelloWorld;
using Scopel.Examples.Life;
using Scopel.Examples.Scopes;

internal class Program
{
	private static void Main(string[] args)
	{
		//Console.WriteLine("Hello World Example");
		//HelloWorld();
		//Console.WriteLine("-------------------");
		//Console.WriteLine("Emit new Objects Example");
		//Emit();
		//Console.WriteLine("-------------------");
		//Console.WriteLine("Create Child Scope");
		//CreateChildScope();
		//Console.WriteLine("-------------------");
		//Console.WriteLine("Life");
		Life();
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
	private static void CreateChildScope()
	{
		var objs = new List<IObjectTemplate>();
		using (var scope = new MasterScope(objs))
			scope.EmitChildScope();
		Task.Delay(1000).Wait();
	}

	private static async void Life() 
	{
		var earth = new Earth();
		var objs = new List<IObjectTemplate> { earth };

		using (var life = new Life(objs)) 
		{
            earth.StartLife();
			Task.Delay(99999).Wait();
			earth.EndLife();
            Console.WriteLine(life.Logs);
        }
	}
}