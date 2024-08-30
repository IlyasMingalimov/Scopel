using Scopel;
using Scopel.Examples.HelloWorld;

internal class Program
{
	private static void Main(string[] args)
	{
		HelloWorld();
	}

	private static void HelloWorld() 
	{
		var sender = new HelloWordSenderObject();
		var recipient = new HelloWordRecipientObject();
		var objs = new List<ObjectTemplate> { sender, recipient };

		using (var scope = new MainScope(objs))
			sender.Hello("Jonh");

		Task.Delay(1000).Wait();
	}
}