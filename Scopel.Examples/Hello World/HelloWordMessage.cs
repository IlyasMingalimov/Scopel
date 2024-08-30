namespace Scopel.Examples.HelloWorld;
public struct HelloWordMessage : IMessageTemplate
{
	public HelloWordMessage(string value) => Value = value;
	public string Value { get; }
}
