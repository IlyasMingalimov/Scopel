namespace Scopel.Examples.HelloWorld;
public class HelloWordSenderObject : ObjectSenderTemplate
{
	internal void Hello(string name) => Send(new HelloWordMessage($"Hello {name}"));
}
