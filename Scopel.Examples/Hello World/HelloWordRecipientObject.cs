namespace Scopel.Examples.HelloWorld;
public class HelloWordRecipientObject : ObjectTemplate
{
	public override void Receive(MessageTemplate message)
	{
		if(message is HelloWordMessage helloMessage) 
			Console.WriteLine(helloMessage.Value);
	}
}
