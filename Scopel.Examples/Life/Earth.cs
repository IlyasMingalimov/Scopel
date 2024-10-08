using Scopel.Examples.Life.Messages;

namespace Scopel.Examples.Life;
internal class Earth : ObjectEmitterTemplate, IObjectRecipientTemplate
{
    public int Resource = 100;
    public void StartLife()
    {
        Send(new LogMessage("Start life simulation"));
        EmitNewLifeObject();
        EmitNewLifeObject();
        AddResource();

    }
    public void EndLife() 
    {
        Send(new LogMessage("End life simulation"));
    }
    private void EmitNewLifeObject() 
    {
        var life = new LIfeObject();
        Emit(life);
        Send(new LogMessage($"life created. Name : {life.name}, guid {life.guid}"));
    }
    public void Receive(IMessageTemplate message)
    {
        if (message is CreateLifeMessage create) 
        {
            if(Resource > 0)
                EmitNewLifeObject();
            Console.WriteLine($"Resurce is {Resource}");
        }

        if(message is EatMessage eat) 
        { 
            if(Resource > 0) 
            {
                Resource--;
                Send(new EatAproveMessage(true, eat.guid));
            }
            else 
            {
                Send(new EatAproveMessage(false, eat.guid));
            }

            Console.WriteLine($"Resurce is {Resource}");
        }
    }

    private void AddResource() 
    {
        if(Resource < 100)
            Resource++;
        Console.WriteLine($"Resurce is {Resource}");
        Task.Delay(300).ContinueWith(t => AddResource());
    }
}
