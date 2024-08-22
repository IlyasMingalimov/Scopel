namespace Scopel.Simple;
public class HelloWordSubscriberObject : ObjectTemplate
{
    public override void ReceiveMessage(MessageTemplate message) => Console.WriteLine(message);

    public void StartSending() 
    {
        var message = new HelloWordMessage(); 
        SendMessage(message);
    }
}
