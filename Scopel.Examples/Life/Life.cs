using Scopel.Examples.Life.Messages;

namespace Scopel.Examples.Life;
internal class Life : ScopeTemplate
{
    public Life(IEnumerable<IObjectTemplate> objs) : base(objs)
    {
    }

    public override void Dispose(){}

    public string Logs { get => ""; }
    public override void Receive(IMessageTemplate message)
    {
        if(message is LogMessage log) 
            Console.WriteLine(log.message);
    }
}
