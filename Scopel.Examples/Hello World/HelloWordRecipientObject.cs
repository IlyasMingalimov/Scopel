namespace Scopel.Examples.HelloWorld;
public class HelloWordRecipientObject : IObjectRecipientTemplate
{
	public void Receive(IMessageTemplate message)
	{
		if(message is HelloWordMessage helloMessage)
			Console.WriteLine(helloMessage.Value);
	}
}
