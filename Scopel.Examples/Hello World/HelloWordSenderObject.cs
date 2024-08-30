namespace Scopel.Examples.HelloWorld;
public class HelloWordSenderObject : ObjectTemplate
{
	public override void Receive(MessageTemplate message) { }
	internal void Hello(string name) => Send(new HelloWordMessage($"Hello {name}"));
}
