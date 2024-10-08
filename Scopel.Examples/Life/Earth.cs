using Scopel.Examples.Life.Messages;

namespace Scopel.Examples.Life;
internal class Earth : ObjectEmitterTemplate
{
    public void StartLife() 
    {
        Send(new LogMessage("Start life simulation"));

        var one = new LIfeObject();
        var two = new LIfeObject();
        Emit(one);
        Emit(two);
        one.LogInit();
        two.LogInit();
        
    }

    public void EndLife() 
    {
        Send(new LogMessage("End life simulation"));
    }
}
