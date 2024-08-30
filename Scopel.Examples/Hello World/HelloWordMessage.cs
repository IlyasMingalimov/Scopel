namespace Scopel.Examples.HelloWorld;
public class HelloWordMessage : MessageTemplate
{
	public HelloWordMessage(string value) => Value = value;

	public string Value { get; }
}
