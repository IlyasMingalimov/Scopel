namespace Scopel.Simple;
public class HelloWordMessage : MessageTemplate<string>
{
    public HelloWordMessage(string value) : base(value)
    {
    }
}
