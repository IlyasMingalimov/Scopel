namespace Scopel.Simple;
public class HelloWordObject : ObjectTemplate
{
    public override void ReceiveMessage(MessageTemplate message)
    {
        Console.WriteLine(message);
        SendMessage(message);
    }
}
