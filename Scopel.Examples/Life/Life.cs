using Scopel.Examples.Life.Messages;

namespace Scopel.Examples.Life;
internal class Life(IEnumerable<IObjectTemplate> objs) : ScopeTemplate(objs)
{
    public override void Dispose(){}

    public string Logs { get => ""; }
    public override void Receive(IMessageTemplate message)
    {
        if(message is LogMessage log) 
            Console.WriteLine(log.message);

        if(message is DeadMessage dead) 
        {
            Console.WriteLine(dead.obj.name + $" died. Lifetime {(DateTime.Now - dead.obj.birthDate).TotalMilliseconds} ms");
            Unsubscribe(dead.obj);
        }
    }
}
