namespace Scopel.Simple;
public class HelloWordPublisherObject : ObjectTemplate
{
    public override void ReceiveMessage(MessageTemplate message){}

    public void StartSending() 
    { 
        var message = new HelloWordMessage();
        SendMessage(message);
    }
}
